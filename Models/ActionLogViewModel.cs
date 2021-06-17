using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Scoliosis.Models
{
    public class ActionLogViewModel
    {
        [Key]
        [Required]
        public Int64 Id { get; set; }

        [Required]
        public DateTime LogDateTime { get; set; }

        [Required]
        public string ActionType { get; set; }

        [Required]
        public string ActionDetail { get; set; }

        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        public string scn { get; set; }

        public DateTime doc { get; set; }

        public string ActionPage { get; set; }

        public static explicit operator InfoDisplayLogViewModel(ActionLogViewModel actionLogViewModel)
        {
            var infoDisplayLogViewModel = new InfoDisplayLogViewModel();

            infoDisplayLogViewModel.id = actionLogViewModel.Id;

            infoDisplayLogViewModel.ActionType = actionLogViewModel.ActionType;

            infoDisplayLogViewModel.ActionPage = actionLogViewModel.ActionPage;

            infoDisplayLogViewModel.ActionDetail = actionLogViewModel.ActionDetail;

            if (actionLogViewModel.doc != null)
            {
                infoDisplayLogViewModel.doc = actionLogViewModel.doc.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else {
                infoDisplayLogViewModel.doc = "";
            }

            if (actionLogViewModel.LogDateTime != null)
            {
                infoDisplayLogViewModel.LogDateTime = actionLogViewModel.LogDateTime.ToString("dd/MM/yyyy HH:mm:ss");
            }
            else
            {
                infoDisplayLogViewModel.LogDateTime = "";
            }

            infoDisplayLogViewModel.ModifiedBy = actionLogViewModel.CreatedBy;

            infoDisplayLogViewModel.scn = actionLogViewModel.scn;

            return infoDisplayLogViewModel;

        }

    }

   



}
