﻿using BootstrapBlazor.Components;
using CnGalWebSite.APIServer.Application.Entries.Dtos;
using CnGalWebSite.DataModel.Application.Dtos;
using CnGalWebSite.DataModel.ExamineModel;
using CnGalWebSite.DataModel.Model;
using CnGalWebSite.DataModel.ViewModel;
using CnGalWebSite.DataModel.ViewModel.Admin;
using CnGalWebSite.DataModel.ViewModel.Entries;
using CnGalWebSite.DataModel.ViewModel.Search;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CnGalWebSite.APIServer.Application.Entries
{
    public interface IEntryService
    {
        Task<PagedResultDto<Entry>> GetPaginatedResult(GetEntryInput input);

        Task<QueryData<ListEntryAloneModel>> GetPaginatedResult(CnGalWebSite.DataModel.ViewModel.Search.QueryPageOptions options, ListEntryAloneModel searchModel);

        Task<PagedResultDto<EntryInforTipViewModel>> GetPaginatedResult(PagedSortedAndFilterInput input);

        void UpdateEntryDataMain(Entry entry, EntryMain examine);

        void UpdateEntryDataAddInfor(Entry entry, EntryAddInfor examine);

        void UpdateEntryDataImages(Entry entry, EntryImages examine);

        Task UpdateEntryDataRelevances(Entry entry, EntryRelevances examine);

        Task UpdateEntryDataTagsAsync(Entry entry, EntryTags examine);

        void UpdateEntryDataMainPage(Entry entry, string examine);

        Task UpdateEntryDataAsync(Entry entry, Examine examine);

        Task<List<int>> GetEntryIdsFromNames(List<string> names);

        Task<EntryEditState> GetEntryEditState(ApplicationUser user, int entryId);

        Task<EntryIndexViewModel> GetEntryIndexViewModelAsync(Entry entry);

        List<KeyValuePair<object, Operation>> ExaminesCompletion(Entry currentEntry, Entry newEntry);

        Task<List<EntryIndexViewModel>> ConcompareAndGenerateModel(Entry currentEntry, Entry newEntry);
    }
}
