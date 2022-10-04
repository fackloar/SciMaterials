﻿using SciMaterials.Domain.Base;

namespace SciMaterials.Domain;

public class FileGroup : Resource
{

    public ICollection<File> Files { get; set; }

    public FileGroup() : base()
    {
        Files = new HashSet<File>();
    }
}
