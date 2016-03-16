using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoArrangement.Models;

namespace CargoArrangement
{
    class Packer
    {
        private RootItem space;

        private int id = 0;
        private int containerWidth;
        private int containerDepth;

        public Packer(int width, int depth)
        {
            containerWidth = width;
            containerDepth = depth;

            this.space = new RootItem
            {
                ContainerNumber = id,
                X = 0,
                Y = 0,
                Width = width,
                Depth = depth
            };

        }

        public ObservableCollection<PalletItem> Fit(ObservableCollection<PalletItem> items, SortCriteria criteria = new SortCriteria())
        {
            RootItem node;
            int id = 0;
            ObservableCollection<PalletItem> block = new ObservableCollection<PalletItem>();

            for (var n=0; n < items.Count; n++)
            {
                //blocksItem = blocks[n];

                var quantity = items[n].Quantity;
                
                switch (items[n].PackageType)
                {
                    case 1:
                        for (var i = 0; i < quantity; i++)
                        {
                            block.Add(new PalletItem()
                                {
                                    ID = ++id,
                                    OrderNumber = items[n].OrderNumber,
                                    ClientName = items[n].ClientName,
                                    PartName = items[n].PartName,
                                    Depth = items[n].Depth,
                                    Width = items[n].Width,
                                    Quantity = 1,
                                    Color = items[n].Color
                                });
                        }
                        break;

                    case 0:
                        while (quantity > 0)
                        {
                            if (quantity - 2 >= 0)
                            {
                                block.Add(new PalletItem()
                                {
                                    ID = ++id,
                                    OrderNumber = items[n].OrderNumber,
                                    ClientName = items[n].ClientName,
                                    PartName = items[n].PartName,
                                    Depth = items[n].Depth,
                                    Width = items[n].Width,
                                    Quantity = 2,
                                    Color = items[n].Color
                                });
                                quantity -= 2;
                            }
                            else if (quantity - 2 < 0)
                            {
                                block.Add(new PalletItem()
                                {
                                    ID = ++id,
                                    OrderNumber = items[n].OrderNumber,
                                    ClientName = items[n].ClientName,
                                    PartName = items[n].PartName,
                                    Depth = items[n].Depth,
                                    Width = items[n].Width,
                                    Quantity = 1,
                                    Color = items[n].Color
                                });
                                quantity--;
                            }
                        }
                        break;
                }

            }

            if (criteria != SortCriteria.None)
                new Sort(block, criteria);

            //Go through all elements
            for (var i = 0; i < block.Count; i++)
            {
                node = this.FindNode(this.space, block[i].Width, block[i].Depth);
                if (node != null)
                {
                    block[i].Fit = this.SplitNode(node, block[i].Width, block[i].Depth);
                }
                else
                {
                    ///Implement if box doesnt fit to current container
                    this.id++;
                    var newPacker = new Packer(containerWidth, containerDepth);
                    this.space = newPacker.space;
                    node = this.FindNode(this.space, block[i].Width, block[i].Depth);
                    block[i].Fit = this.SplitNode(node, block[i].Width, block[i].Depth);

                }
            }

            return block;
        }


        private RootItem SplitNode(RootItem node, int width, int depth)
        {
            node.Used = true;
            node.ContainerNumber = id;

            node.Down = new RootItem
            {
                X = node.X,
                Y = node.Y + depth,
                Width = node.Width,
                Depth = node.Depth - depth
            };

            node.Right = new RootItem
            {
                X = node.X + width,
                Y = node.Y,
                Width = node.Width - width,
                Depth = depth
            };

            return node;
        }

        private RootItem FindNode(RootItem space, decimal width, decimal depth)
        {
            if (space.Used)
            {
                var spaceRight = this.FindNode(space.Right, width, depth);
                var spaceDown = this.FindNode(space.Down, width, depth);

                if (spaceRight != null)
                    return spaceRight;
                else if ((spaceRight == null) & (spaceDown != null))
                    return spaceDown;
                else return null;
            }
            else if ((width <= space.Width) & (depth <= space.Depth))
                return space;
            else
                return null;
        }
    }
}
