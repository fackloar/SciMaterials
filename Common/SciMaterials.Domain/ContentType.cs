﻿using SciMaterials.Domain.Base;

namespace SciMaterials.Domain;

public class ContentType : NamedModel
{
    public ICollection<File> Files { get; set; }

    public ContentType()
    {
        Files = new HashSet<File>();
    }
}
