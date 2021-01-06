<template>
  <div>
    <v-card class="mx-auto overflow-hidden" >
      <v-app-bar color="teal lighten-1" dark>
        <v-app-bar-nav-icon @click="drawer = true"></v-app-bar-nav-icon>
        <v-toolbar-title>Academy</v-toolbar-title>
        <v-autocomplete
          v-model="select"
          :loading="loading"
          :items="items"
          :search-input.sync="search"
          cache-items
          class="mx-6"
          flat
          hide-no-data
          hide-details
          label="Bạn đang tìm kiếm điều gì ?"
          solo-inverted
          style="max-width: 500px !important"
        ></v-autocomplete>
        <div class="box-icon" >
          <v-btn icon>
            <v-icon title="Quản lý khóa học">mdi-chat-outline</v-icon>
          </v-btn>
          <v-btn icon>
            <v-icon>mdi-heart</v-icon>
          </v-btn>
          <v-btn icon>
            <v-icon>mdi-dots-vertical</v-icon>
          </v-btn>
        </div>
      </v-app-bar>

      <v-navigation-drawer v-model="drawer" absolute temporary>
        <v-list nav dense>
          <v-list-item-group
            v-model="group"
            active-class="deep-purple--text text--accent-4"
          >
            <v-list-item>
              <v-list-item-icon>
                <v-icon>mdi-home</v-icon>
              </v-list-item-icon>
              <v-list-item-title>Home</v-list-item-title>
            </v-list-item>

            <v-list-item>
              <v-list-item-icon>
                <v-icon>mdi-account</v-icon>
              </v-list-item-icon>
              <v-list-item-title>Account</v-list-item-title>
            </v-list-item>
          </v-list-item-group>
        </v-list>
      </v-navigation-drawer>
    </v-card>
  </div>
</template>

<script>
export default {
  data: () => ({

  }),
};
</script>

<style>
.box-icon{
    display: flex;
    justify-content: flex-end;
    width: 54%;
}
</style>