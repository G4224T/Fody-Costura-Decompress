# Fody-Costura-Decompress

See https://github.com/fody/costura for further details on Fody.

The Fody-Costura Library for .NET 4.5 (and over) compresses resources and adds them into an assembly automatically at compile time to reduce the number of files required for distribution.

To de-compile a .NET assembly, the resources are required. Most de-compilers can extract the resources but they are extracted as compressed files with a .zip extension. The .zip extension is incompatible with the standard zip file format. 

This simple utility uses the .NET compression / de-compression library available in .NET 4.5 and over to de-compress the zip file so that it can be de-compiled.

NOTES
-----
This is a quick utility thrown together in a rush solely to de-compress files that I required. It has no error checking whatsoever. If the output file exists, it WILL be overwritten so check that any required files are copied / renamed / backed up first.

The de-compressed file is written using the filename of the existing file minus the .zip extention. On some de-compilers, such as Jet Brains, the resources are extracted into folders and given a name that relates (mostly) to the extension.

I.E if a resource is compressed as foo.bar.dll.zip, this utility would extract the file as foo.bar.dll, however the Jet Brains de-compiler extracts the foo.bar.dll.zip to c:\wherever\foo\bar\dll.zip. It is recommended that the file is renamed to it's original name before de-compression.

