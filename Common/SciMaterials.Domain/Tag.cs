﻿using SciMaterials.Domain.Base;

namespace SciMaterials.Domain;

public class Tag : NamedModel
{
    public ICollection<File> Files { get; set; }
    
    public ICollection<FileGroup> FileGroups { get; set; }

    public Tag()
    {
        Files = new HashSet<File>();
        FileGroups = new HashSet<FileGroup>();
    }
}
