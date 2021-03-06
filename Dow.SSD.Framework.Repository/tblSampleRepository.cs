//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template, at 07/01/2016 15:36:19
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Dow.SSD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace Dow.SSD.Framework.Repository
{
    public partial class tblSampleRepository
    {
    		private SSDFrameworkSampleDBEntities _context = null;
    
    		public tblSampleRepository(SSDFrameworkSampleDBEntities context)
    		{
    			_context = context;
    		}
    		
    		public bool Add(tblSample entity)
            {
    			_context.tblSamples.Add(entity as tblSample);
    			return true;
            }
    		
    		public bool Add(List<tblSample> entities)
            {
                entities.ForEach(entity =>
                {
                    _context.tblSamples.Add(entity as tblSample);
                });
    
    			return true;
            }
    
            public bool Update(tblSample entity)
            {
                _context.tblSamples.Attach(entity as tblSample);
                _context.Entry(entity as tblSample).State = EntityState.Modified;
    
    			return true;
            }
    
            public bool Delete(tblSample entity)
            {
                _context.tblSamples.Attach(entity as tblSample);
                _context.tblSamples.Remove(entity as tblSample);
                  
               	return true;
            }
    
            public bool Delete(List<tblSample> entities)
            {
                entities.ForEach(entity =>
                {
                    _context.tblSamples.Attach(entity as tblSample);
                    _context.tblSamples.Remove(entity as tblSample);
                });
                return true;
            }
         
            public bool Delete(Expression<Func<tblSample, bool>> predicate)
            {
                var deleteEntity = this.FindAllBy(predicate);
    			this.FindAllBy(predicate).ToList().ForEach(entity =>
                {
                    _context.tblSamples.Attach(entity as tblSample);
                    _context.tblSamples.Remove(entity as tblSample);
                });
    
                return true;
            }
    
    		public tblSample FindSingleBy(Expression<Func<tblSample, bool>> predicate)
            {           
    		    _context.Configuration.ProxyCreationEnabled = false;
                var returnValue = _context.tblSamples.Where(predicate).FirstOrDefault();
                return returnValue as tblSample;
            }
    
    		 public List<tblSample> FindAllBy(Expression<Func<tblSample, bool>> predicate)
            {
    		    _context.Configuration.ProxyCreationEnabled = false;
                return _context.tblSamples.Where(predicate).ToList();
            }
         
            public List<tblSample> GetAll()
            {
    			_context.Configuration.ProxyCreationEnabled = false;
                var returnValue = _context.tblSamples.ToList();
                return returnValue.Cast<tblSample>().ToList();
            }
    
    		public void SaveChanges()
    		{
    			_context.SaveChanges();
    		}
    		
    }
}
