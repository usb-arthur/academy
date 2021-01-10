<template>
  <v-card>
    <v-divider></v-divider>
    <v-card-text>
      <v-container>
        <v-row class="mx-10">
          <v-col cols="12">
            <v-text-field
              v-model="currentPassword"
              type="password"
              hide-details
              outlined
              label="Mật khẩu hiện tại"
            ></v-text-field>
          </v-col>
          <v-col cols="12">
            <v-text-field
              v-model="newPassword"
              type="password"
              hide-details
              outlined
              label="Mật khẩu mới"
            ></v-text-field>
          </v-col>
          <v-col cols="12">
            <v-text-field
              v-model="confirmPassword"
              type="password"
              hide-details
              outlined
              label="Xác nhận mật khẩu"
            ></v-text-field>
          </v-col>
          <v-col cols="12">
            <v-btn
              @click="submit({ currentPassword, newPassword, confirmPassword })"
              block
              color="primary"
              >Đổi mật khẩu</v-btn
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
import { mapActions } from "vuex";

export default {
  data: () => ({
    currentPassword: "",
    newPassword: "",
    confirmPassword: "",
    snackbar: false,
    text: ""
  }),
  watch: {
    text(val) {
      if (!this.snackbar && val != "") {
        this.snackbar = true;
      }
    },
    snackbar(val) {
      if (!val) {
        this.text = "";
      }
    }
  },
  methods: {
    ...mapActions("auth", ["changePassword"]),
    submit(authReq) {
      this.changePassword(authReq)
        .then(() => {
          this.text = "Đổi mật khẩu thành công";
          this.clear();
        })
        .catch(err => {
          this.text = err.response.data.message;
        });
    },
    clear() {
      this.changePassword = this.currentPassword = this.confirmPassword = "";
    }
  }
};
</script>
