# Zen.Hexagons

Hexagon routines for use in for software that uses hexagon grids.
Can be used for pointy-topped or flat-topped hexes and offset, axial or cube coordinate systems.

Uses ideas from Amit Patel's brilliant http://www.redblobgames.com/grids/hexagons/.

# Example
To use:

    var hexLibrary = new Zen.Hexagons.HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);
    var hexCube = hexLibrary.OffsetCoordinatesToCube(new HexOffsetCoordinates(2, 2));
    
# Developer
Written by Greg Moller (greg.moller@gmail.com)

# License
Licensed under the MIT License. See the LICENCE file for more information.
