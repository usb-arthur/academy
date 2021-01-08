<template>
  <div>
    <md-table
      v-model="searched"
      md-sort="name"
      md-sort-order="asc"
      @md-selected="onSelect"
      md-card
      md-fixed-header
    >
      <md-table-toolbar>
        <div class="md-toolbar-section-start">
          <h1 class="md-title">LĨNH VỰC</h1>
        </div>

        <md-field md-clearable class="md-toolbar-section-end">
          <md-input
            placeholder="Tìm theo tên..."
            v-model="search"
            @input="searchOnTable"
          />
        </md-field>
      </md-table-toolbar>

      <md-table-toolbar slot="md-table-alternate-header" slot-scope="{ count }">
        <div class="md-toolbar-section-start">Đã chọn {{ count }} lĩnh vực</div>

        <div class="md-toolbar-section-end">
          <md-button
            v-if="morethanone"
            class="md-icon-button"
            @click="detailCatalog"
          >
            <md-icon>assignment</md-icon>
          </md-button>
          <md-button
            v-if="morethanone"
            class="md-icon-button"
            @click="assignCatalog"
          >
            <md-icon>settings</md-icon>
          </md-button>
          <md-button
            v-if="morethanone"
            class="md-icon-button"
            @click="renameCatalog"
          >
            <md-icon>create</md-icon>
          </md-button>
          <md-button class="md-icon-button" @click="deleteCatalog">
            <md-icon>delete</md-icon>
          </md-button>
        </div>
      </md-table-toolbar>

      <md-table-empty-state
        md-label="Không tìm thấy lĩnh vực"
        :md-description="
          `Không tìm thấy lĩnh vực tên '${search}'. Thử tìm theo tên khác hoặc tạo mới.`
        "
      >
        <md-button class="md-primary md-raised" @click="newUser"
          >Tạo lĩnh vực mới</md-button
        >
      </md-table-empty-state>

      <md-table-row
        slot="md-table-row"
        slot-scope="{ item }"
        md-selectable="multiple"
        md-auto-select
      >
        <md-table-cell md-label="ID" md-numeric>{{ item.id }}</md-table-cell>
        <md-table-cell md-label="Catalog" md-sort-by="catalogname">{{
          item.catalogname
        }}</md-table-cell>
        <md-table-cell md-label="Active" md-sort-by="active">{{
          item.active
        }}</md-table-cell>
      </md-table-row>
    </md-table>
  </div>
</template>

<script>
export default {
  name: "TableSearch",
  data: () => ({
    search: null,
    searched: [],
    selected: []
  }),
  computed: {
    dslinhvucs() {
      return this.$store.state.linhvuc.items;
    },
    searchByName() {
      if (this.search) {
        return this.dslinhvucs.filter(item =>
          item.catalogname.toLowerCase().includes(this.search.toLowerCase())
        );
      }

      return this.dslinhvucs;
    },
    morethanone() {
      if (this.selected.length < 2) return true;
      return false;
    }
  },
  methods: {
    newUser() {
      window.alert("Noop");
    },
    onSelect(items) {
      this.selected = items;
    },
    activeCatalog() {
      window.alert("Active");
    },
    renameCatalog() {
      window.alert("rename");
    },
    assignCatalog() {
      window.alert("assign");
    },
    detailCatalog() {
      window.alert("detail");
    },
    deleteCatalog() {
      window.alert("Delete");
    },
    searchOnTable() {
      this.searched = this.searchByName;
    }
  },
  created() {
    this.searched = this.dslinhvucs;
  }
};
</script>

<style lang="scss" scoped>
.md-field {
  max-width: 300px;
}
</style>
