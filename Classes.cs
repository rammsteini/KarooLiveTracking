namespace KarooLiveTracking
{
    public class ActivityInfo
    {
        public string? key { get; set; }
        public Value? value { get; set; }
    }

    public class Elevation
    {
        public double? gain { get; set; }
        public double? loss { get; set; }
        public double? max { get; set; }
        public double? min { get; set; }
        public string? polyline { get; set; }
        public string? source { get; set; }
    }

    public class LiveTrack
    {
        public List<ActivityInfo>? activityInfo { get; set; }
        public double? bearing { get; set; }
        public DateTime? createdAt { get; set; }

        public double EastBound
        {
            get
            {
                if (locations == null)
                {
                    return 0.0;
                }
                return locations.Max(r => r.lng);
            }
        }

        public string? id { get; set; }

        public Location? location { get; set; }

        public List<Location>? locations { get; set; }

        public double NorthBound
        {
            get
            {
                if (locations == null)
                {
                    return 0.0;
                }
                return locations.Max(r => r.lat);
            }
        }

        public string? riderName { get; set; }

        public Route? route { get; set; }

        public double SouthBound
        {
            get
            {
                if (locations == null)
                {
                    return 0.0;
                }
                return locations.Min(r => r.lat);
            }
        }

        public string? state { get; set; }

        public DateTime? updatedAt { get; set; }

        public double WestBound
        {
            get
            {
                if (locations == null)
                {
                    return 0.0;
                }
                return locations.Min(r => r.lng);
            }
        }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class PointsOfInterest
    {
        public string? description { get; set; }
        public Location? location { get; set; }
        public string? name { get; set; }
        public string? type { get; set; }
    }

    public class Route
    {
        public double? distance { get; set; }

        public double EastBound
        {
            get
            {
                if (route == null)
                {
                    return 0.0;
                }
                return route.Max(r => r.lng);
            }
        }

        public Elevation? elevation { get; set; }
        public string? name { get; set; }

        public double NorthBound
        {
            get
            {
                if (route == null)
                {
                    return 0.0;
                }
                return route.Max(r => r.lat);
            }
        }

        public List<PointsOfInterest>? pointsOfInterest { get; set; }

        public int PointsOfInterestHash
        {
            get
            {
                var txt = String.Join("", pointsOfInterest.Select(r => r.name + r.description + r.location.lat + r.location.lng));
                return txt.GetHashCode();
            }
        }

        public List<Location>? route { get; set; }
        public string? routePolyline { get; set; }

        public double SouthBound
        {
            get
            {
                if (route == null)
                {
                    return 0.0;
                }
                return route.Min(r => r.lat);
            }
        }

        public List<Waypoint>? waypoints { get; set; }

        public double WestBound
        {
            get
            {
                if (route == null)
                {
                    return 0.0;
                }
                return route.Min(r => r.lng);
            }
        }
    }

    public class Value
    {
        public string? format { get; set; }
        public double? value { get; set; }
    }

    public class Waypoint
    {
        public double? lat { get; set; }
        public double? lng { get; set; }
    }
}