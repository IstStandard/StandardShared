using System.ComponentModel.DataAnnotations;

namespace StandardShared.Database.Models;

public interface IBaseModel
{
    [Key] public Guid Uid { get; init; }
}