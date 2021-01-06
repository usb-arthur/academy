<template>
  <div>
    <v-data-table
      :headers="headers"
      :items="desserts"
      sort-by="calories"
      class="elevation-1 mt-4"
    >
     <template v-slot:item.image="{ item }">
            <div class="p-2">
              <v-img :src="'https://img-b.udemycdn.com/course/240x135/543600_64d1_4.jpg?secure=1fzbDv9TFefw8aQKTuMx_g%3D%3D%2C1610035097'" :alt="item.Name" height="100px"></v-img>
            </div>
          </template> 
    </v-data-table>
  </div>
</template>

<script>
export default {
  data: () => ({
      dialog: false,
      dialogDelete: false,
      headers: [
        {
          text: 'Hình đại diện',
          align: 'start',
          sortable: false,
          value: 'Image',
        },
        { text: 'Tên khóa học', value: 'Name' },
        { text: 'Mô tả ngắn gọn', value: 'Description' },
        { text: 'Điểm đánh giá', value: 'Point' },
        { text: 'Lần cập nhật cuối', value: 'UpdateDate' },
        { text: 'Actions', value: 'actions', sortable: false },
      ],
      desserts: [],     
    }),

    computed: {
      formTitle () {
        return this.editedIndex === -1 ? 'New Item' : 'Edit Item'
      },
    },

    watch: {
      dialog (val) {
        val || this.close()
      },
      dialogDelete (val) {
        val || this.closeDelete()
      },
    },

    created () {
      this.initialize()
    },

    methods: {
      initialize () {
        this.desserts = [
          {
            
            Name: 159,
            Description: 6.0,
            Point: 24,
            UpdateDate: 4.0,
          },
          {
            
            Name: 159,
            Description: 6.0,
            Point: 24,
            UpdateDate: 4.0,
          },
          {
            
            Name: 159,
            Description: 6.0,
            Point: 24,
            UpdateDate: 4.0,
          },         
        ]
      },     
    },
};
</script>

<style>
</style>