<template>
  <v-dialog v-model="dialog" max-width="800">
    <template v-slot:activator="{ on, attrs }">
      <v-btn v-bind="attrs" v-on="on" class="mt-2" block color="primary">
        Thêm nội dung
      </v-btn>
    </template>
    <v-card>
      <v-card-title>
        <span class="headline">Thêm Nội Dung</span>
      </v-card-title>
      <v-card-text>
        <v-container>
          <v-row>
            <v-col cols="6">
              <v-text-field
                label="Nội dung"
                required
                v-model="courseDetail.content"
                hide-details
                :rules="[v => !!v || 'Nội dung không được để trống']"
              ></v-text-field>
            </v-col>
            <v-col cols="6">
              <v-file-input
                show-size
                v-model="courseDetail.video"
                accept="video/mp4, video/avi"
                hide-details
                label="Chèn video"
              ></v-file-input>
            </v-col>
            <v-col cols="12">
              <v-checkbox
                v-model="courseDetail.isReview"
                hide-details
                label="Cho xem trước?"
              ></v-checkbox>
            </v-col>
          </v-row>
        </v-container>
      </v-card-text>
      <v-card-actions>
        <v-spacer></v-spacer>
        <v-btn color="blue darken-1" text @click="dialog = false">
          Đóng
        </v-btn>
        <v-btn
          color="blue darken-1"
          text
          @click="createNewCourseDetail($route.params.id, courseDetail)"
        >
          Tạo
        </v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
import { mapActions } from "vuex";

export default {
  data: () => ({
    dialog: false,
    courseDetail: {
      isReview: false,
      content: "",
      video: null
    }
  }),
  methods: {
    ...mapActions("course", ["createCourseDetail"]),
    createNewCourseDetail(id, courseDetail) {
      this.courseDetail={};
      this.createCourseDetail({ id, courseDetail })
        .then(() => {
          this.dialog = false;
          this.$emit("handleSuccess");
        })
        .catch(err => {
          this.$emit("handleError", err.response.data.message);
        });
    },
    setDefaultValue() {
      this.isReview = false;
      this.content = "";
    }
  }
};
</script>
