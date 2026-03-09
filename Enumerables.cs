using System;

namespace Capstone;

public enum Collection
{
    Fiction,
    NonFiction,
    Biography,
    Mystery,
    ScienceFiction,
    UrbanFiction,
    Romance,
}

public enum BookFormat
{
    Hardcover,
    Paperback,
    Audiobook,
    LargeType,
    eBook,
}

public enum CircStatus
{
    In,
    Out,
    Held,
    Lost,
    Withdrawn,
    InTransit,
}