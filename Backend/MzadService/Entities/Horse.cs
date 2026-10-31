using System;

namespace MzadService.Entities;

public class Horse
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Father { get; set; }
    public string? Mother { get; set; }
    public required string Breed { get; set; }
    public int YearOfBirth { get; set; }
    public required string Color { get; set; }
    public string? ImageUrl { get; set; }

    // navigation properties
    public Mzad Mzad { get; set; } = null!;
    public Guid MzadId { get; set; }
}
