<template>
  <v-container>
    <v-row>
      <v-col cols="4">
        <v-card>
          <v-list-item-group>
            <v-list-item>Thông tin cá nhân</v-list-item>
            <v-list-item>Khóa học của tôi</v-list-item>
            <v-list-item>Danh sách yêu thích của tôi</v-list-item>
            <v-list-item>Đổi mật khẩu</v-list-item>
          </v-list-item-group>
        </v-card>
      </v-col>
      <v-col cols="8">
        <router-view></router-view>
      </v-col>
    </v-row>
  </v-container>
</template>
