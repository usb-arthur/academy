<template>
  <v-card>
    <v-divider></v-divider>
    <v-card-text>
      <v-container>
        <v-row class="mx-10">
          <v-col cols="12">
            <v-text-field
              v-model="user.email"
              disabled
              type="email"
              hide-details
              outlined
              label="Email"
              readonly
            ></v-text-field>
          </v-col>
          <v-col cols="12">
            <v-text-field
              v-model="user.name"
              hide-details
              outlined
              label="Họ và tên"
            ></v-text-field>
          </v-col>
          <v-col cols="12">
            <v-text-field
              v-model="user.phoneNumber"
              type="number"
              hide-details
              outlined
              label="Số điện thoại"
            ></v-text-field>
          </v-col>
          <v-col cols="12">
            <v-select
              v-model="user.userGender"
              :items="gender"
              item-text="value"
              item-value="id"
              hide-details
              outlined
              label="Giới tính"
            ></v-select>
          </v-col>
          <v-col cols="12">
            <v-text-field
              v-model="user.dateOfBirth"
              type="date"
              hide-details
              outlined
              label="Ngày sinh"
            ></v-text-field>
          </v-col>
          <v-col cols="12">
            <v-btn block color="primary" @click="saveChanges(user)"
              >Lưu thay đổi</v-btn
            >
          </v-col>
        </v-row>
      </v-container>
    </v-card-text>
    <v-snackbar v-model="snackbar" timeout="2000">
      {{ text }}
      <template v-slot:action="{ attrs }">
        <v-btn color="blue" text v-bind="attrs" @click="snackbar = false">
          Đóng
        </v-btn>
      </template>
    </v-snackbar>
  </v-card>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  data: () => ({
    snackbar: false,
    text: "",
    gender: [
      {
        id: 0,
        value: "Male"
      },
      {
        id: 1,
        value: "Female"
      },
      {
        id: 2,
        value: "Other"
      }
    ]
  }),
  watch: {
    text() {
      this.snackbar = true;
    }
  },
  created() {
    this.getUserInformation();
  },
  computed: {
    ...mapState("account", ["user"])
  },
  methods: {
    ...mapActions("account", ["getUserInformation", "patchUser"]),
    saveChanges(user) {
      this.patchUser(user)
        .then(() => {
          this.text = "Cập nhật thành công";
        })
        .catch(err => {
          this.text = err.response.statusText.message || "Có lỗi xảy ra";
        });
    }
  }
};
</script>
