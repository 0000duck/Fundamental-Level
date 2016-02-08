using System;
using System.Collections.Generic;
using Theatre.Exceptions;

namespace Theatre.Interfaces
{
    /// <summary>
    /// Defines a database (repository) holding theatres and performances and
    /// add / list operations for theatres and performances in theаtres. 
    /// </summary>
    public interface IPerformanceDatabase
    {
        /// <summary>
        /// Adds a new theatre to the database.
        /// </summary>
        /// <param name="theatreName">The name of the theatre</param>
        /// <exception cref="TheatreNotFoundException">Thrown in case of duplicate theatre. 
        /// Holds a "Duplicate theatre" as error message.</exception>
        void AddTheatre(string theatreName);

        /// <summary>
        /// Lists all theatres ordered by name.
        /// </summary>
        /// <returns>List of theatre names</returns>
        IEnumerable<string> ListTheatres();

        /// <summary>
        /// Adds a new performance to an existing theatre. The performance cannot overlap
        /// with another performance in the same theatre.
        /// </summary>
        /// <param name="theatreName">The name of the theatre</param>
        /// <param name="performanceTitle">The title of the performance</param>
        /// <param name="startDateTime">The performance start date and time</param>
        /// <param name="duration">The performance duration</param>
        /// <param name="price">The price of the performance</param>
        /// <exception cref="TheatreNotFoundException">Thrown with message "Theatre does not exist"
        /// in case of non-existing theatre.</exception>
        /// <exception cref="TimeDurationOverlapException">Thrown with message "Time/duration overlap"
        /// in case of the time interval overlaps with another performance time interval
        /// in the same theatre.</exception>
        void AddPerformance(string theatreName, string performanceTitle, DateTime startDateTime, TimeSpan duration, decimal price);

        /// <summary>
        /// Lists all performances from all theatres ordered by theatre name
        /// and then by performance date and time.
        /// </summary>
        /// <returns>List of all performances</returns>
        IEnumerable<Performance> ListAllPerformances();

        /// <summary>
        /// Lists all performances from a specified theatre ordered by performance date and time.
        /// </summary>
        /// <param name="theatreName">The name of the theatre</param>
        /// <returns>List of performances from the speicified theatre</returns>
        /// <exception cref="TheatreNotFoundException">Thrown with message "Theatre does not exist"
        /// in case of non-existing theatre.</exception>
        IEnumerable<Performance> ListPerformances(string theatreName);
    }
}