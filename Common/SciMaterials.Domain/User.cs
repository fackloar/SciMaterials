﻿using SciMaterials.Domain.Base;

namespace SciMaterials.Domain;

public class User : NamedModel
{
    public string Email { get; set; } = string.Empty;

    public ICollection<Comment> Comments { get; set; }
    public ICollection<File> Files { get; set; }
    public ICollection<Rating> Ratings { get; set; }

    public User()
    {
        Comments = new HashSet<Comment>();
        Files = new HashSet<File>();
        Ratings = new HashSet<Rating>();
    }
}
