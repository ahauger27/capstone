using System;
using Capstone.Models;

namespace Capstone.Services;

public static class Circulation
{
    public static void CheckOutItem(Patron patron, IItem item)
    {
        if (item.CircStatus == CircStatus.In)
    }
}