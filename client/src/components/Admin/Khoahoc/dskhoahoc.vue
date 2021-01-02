<template>
    <div>
        <md-table v-model="searched" md-sort="name" md-sort-order="asc" @md-selected="onSelect" md-card md-fixed-header>
            <md-table-toolbar>
                <div class="md-toolbar-section-start">
                    <h1 class="md-title">LĨNH VỰC</h1>
                </div>

                <md-field md-clearable class="md-toolbar-section-end">
                    <md-input placeholder="Tìm theo tên..." v-model="search" @input="searchOnTable" />
                </md-field>
            </md-table-toolbar>

                  <md-table-toolbar slot="md-table-alternate-header" slot-scope="{ count }">
                      <div class="md-toolbar-section-start">Đã chọn {{count}} lĩnh vực</div>

                      <div class="md-toolbar-section-end">
                          <md-button class="md-icon-button" @click="deletekh">
                              <md-icon>delete</md-icon>
                          </md-button>
                      </div>
                  </md-table-toolbar>

            <md-table-empty-state md-label="Không tìm thấy khóa học"
                :md-description="`Không tìm thấy lĩnh vực tên '${search}'. Thử tìm theo tên khác hoặc tạo mới.`">
                <md-button class="md-primary md-raised" @click="newUser">Tạo khóa học mới</md-button>
            </md-table-empty-state>

            <md-table-row slot="md-table-row" slot-scope="{ item }" md-selectable="multiple" md-auto-select>
                <md-table-cell md-label="ID" md-numeric>{{ item.id }}</md-table-cell>
                <md-table-cell md-label="Tên" md-sort-by="name">{{ item.name }}</md-table-cell>
                <md-table-cell md-label="Tình trạng" md-sort-by="active">{{ item.active }}</md-table-cell>
            </md-table-row>
        </md-table>
    </div>
</template>

<script>

    export default {
        name: 'TableSearch',
        data: () => ({
            search: null,
            searched: [],
            selected: []
        }),
        computed: {
            dskhoahoc() {
                return this.$store.state.khoahoc.items;
            },
            searchByName() {
                if (this.search) {
                    return this.dskhoahoc.filter(item => item.name.toLowerCase().includes(this.search.toLowerCase()))
                }

                return this.dskhoahoc
            },
            morethanone() {
                if (this.selected.length < 2)
                    return true;
                return false;
            }
        },
        methods: {
            newUser() {
                window.alert('Noop')
            },
            onSelect (items) {
            this.selected = items
            },
            deletekh() {
                window.alert('Delete')
            },
            searchOnTable() {
                this.searched = this.searchByName
            }
        },
        created() {
            this.searched = this.dskhoahoc
        }
    }
</script>

<style lang="scss" scoped>
    .md-field {
        max-width: 300px;
    }
</style>