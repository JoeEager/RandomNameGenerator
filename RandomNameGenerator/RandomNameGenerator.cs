using System;
using System.Linq;



namespace RandomNameGenerator
{
    public class RandomNameGenerator
    {
     

        public string GetRandomLastName()
        {
            try
            {

                using (var db = new NameData())
                {
                    //Get the total number of records in the LastName table
                    int count = (from c in db.LastName select c.name).Count();

                    //Determine a random ranking to pull
                    int randomRank = new Random().Next(1, count);

                    //Return a random lastname
                    string result = (from n in db.LastName
                                     where n.rank == randomRank
                                     select n.name).Single().ToString();

                    return result;

                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        } 
       
 
        public string GetRandomLastName(int Percentile)
        {
            try
            {
                using (var db = new NameData())
                {
                    //Get the last names in the percentile
                    var results = (from c in db.LastName
                                   orderby c.rank descending
                                   where c.cumPercentFrequency <= 100 - Percentile
                                   select c.name).ToList();

                    //Grab a random name from the list
                    string result = results.ElementAt(new Random().Next(0, results.Count()));

                    return result;
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                return null;
            }
            catch
            {
                throw;
            }
        }

        public string GetRandomFemaleFirstName()
        {
            try
            {
                using (var db = new NameData())
                {
                    //Get the total number of records in the LastName table
                    int count = (from c in db.FemaleFirstName select c.name).Count();

                    //Determine what random row to get (doing this here works better)
                    int rowNumber = new Random().Next(1, count);

                    //Return a random lastname
                    string result = (from n in db.FemaleFirstName
                                     where n.rank == rowNumber
                                     select n.name).Single().ToString();

                    return result;
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                return null;
            }
            catch
            {
                throw;
            }


        }

        public string GetRandomFemaleFirstName(int Percentile)
        {
            try
            {

                using (var db = new NameData())
                {
                    //Get the last names in the percentile
                    var results = (from c in db.FemaleFirstName
                                   orderby c.rank descending
                                   where c.cumPercentFrequency <= 100 - Percentile
                                   select c.name).ToList();

                    //Grab a random name from the list
                    string result = results.ElementAt(new Random().Next(0, results.Count()));

                    return result;
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                return null;
            }
            catch
            {
                throw;
            }
        }

        public string GetRandomMaleFirstName()
        {
            try
            {
                using (var db = new NameData())
                {
                    //Get the total number of records in the LastName table
                    int count = (from c in db.MaleFirstName select c.name).Count();

                    //Determine what random row to get (doing this here works better)
                    int rowNumber = new Random().Next(1, count);

                    //Return a random lastname
                    string result = (from n in db.MaleFirstName
                                     where n.rank == rowNumber
                                     select n.name).Single().ToString();

                    return result;
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                return null;
            }
            catch
            {
                throw;
            }

        }

        public string GetRandomMaleFirstName(int Percentile)
        {
            try
            {
                using (var db = new NameData())
                {
                    //Get the last names in the percentile
                    var results = (from c in db.MaleFirstName
                                   orderby c.rank descending
                                   where c.cumPercentFrequency <= 100 - Percentile
                                   select c.name).ToList();

                    //Grab a random name from the list
                    string result = results.ElementAt(new Random().Next(0, results.Count()));

                    return result;
                }
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                return null;
            }
            catch
            {
                throw;
            }
        }

    }
    
}
