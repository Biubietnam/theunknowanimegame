using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000787 RID: 1927
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetQuestDataScRsp : IMessage<GetQuestDataScRsp>, IMessage, IEquatable<GetQuestDataScRsp>, IDeepCloneable<GetQuestDataScRsp>, IBufferMessage
	{
		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06005615 RID: 22037 RVA: 0x000E70B9 File Offset: 0x000E52B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetQuestDataScRsp> Parser
		{
			get
			{
				return GetQuestDataScRsp._parser;
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06005616 RID: 22038 RVA: 0x000E70C0 File Offset: 0x000E52C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetQuestDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06005617 RID: 22039 RVA: 0x000E70D2 File Offset: 0x000E52D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetQuestDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x000E70D9 File Offset: 0x000E52D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestDataScRsp()
		{
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x000E70EC File Offset: 0x000E52EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestDataScRsp(GetQuestDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.totalAchievementExp_ = other.totalAchievementExp_;
			this.questList_ = other.questList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x000E7139 File Offset: 0x000E5339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestDataScRsp Clone()
		{
			return new GetQuestDataScRsp(this);
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x0600561B RID: 22043 RVA: 0x000E7141 File Offset: 0x000E5341
		// (set) Token: 0x0600561C RID: 22044 RVA: 0x000E7149 File Offset: 0x000E5349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x0600561D RID: 22045 RVA: 0x000E7152 File Offset: 0x000E5352
		// (set) Token: 0x0600561E RID: 22046 RVA: 0x000E715A File Offset: 0x000E535A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TotalAchievementExp
		{
			get
			{
				return this.totalAchievementExp_;
			}
			set
			{
				this.totalAchievementExp_ = value;
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x0600561F RID: 22047 RVA: 0x000E7163 File Offset: 0x000E5363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Quest> QuestList
		{
			get
			{
				return this.questList_;
			}
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x000E716B File Offset: 0x000E536B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetQuestDataScRsp);
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x000E717C File Offset: 0x000E537C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetQuestDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.TotalAchievementExp == other.TotalAchievementExp && this.questList_.Equals(other.questList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x000E71DC File Offset: 0x000E53DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.TotalAchievementExp != 0U)
			{
				num ^= this.TotalAchievementExp.GetHashCode();
			}
			num ^= this.questList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x000E7242 File Offset: 0x000E5442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x000E724A File Offset: 0x000E544A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x000E7254 File Offset: 0x000E5454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalAchievementExp != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.TotalAchievementExp);
			}
			this.questList_.WriteTo(ref output, GetQuestDataScRsp._repeated_questList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x000E72C0 File Offset: 0x000E54C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.TotalAchievementExp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TotalAchievementExp);
			}
			num += this.questList_.CalculateSize(GetQuestDataScRsp._repeated_questList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x000E732C File Offset: 0x000E552C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetQuestDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.TotalAchievementExp != 0U)
			{
				this.TotalAchievementExp = other.TotalAchievementExp;
			}
			this.questList_.Add(other.questList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x000E738D File Offset: 0x000E558D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x000E7398 File Offset: 0x000E5598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 106U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.questList_.AddEntriesFrom(ref input, GetQuestDataScRsp._repeated_questList_codec);
					}
				}
				else
				{
					this.TotalAchievementExp = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040021B7 RID: 8631
		private static readonly MessageParser<GetQuestDataScRsp> _parser = new MessageParser<GetQuestDataScRsp>(() => new GetQuestDataScRsp());

		// Token: 0x040021B8 RID: 8632
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021B9 RID: 8633
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040021BA RID: 8634
		private uint retcode_;

		// Token: 0x040021BB RID: 8635
		public const int TotalAchievementExpFieldNumber = 7;

		// Token: 0x040021BC RID: 8636
		private uint totalAchievementExp_;

		// Token: 0x040021BD RID: 8637
		public const int QuestListFieldNumber = 13;

		// Token: 0x040021BE RID: 8638
		private static readonly FieldCodec<Quest> _repeated_questList_codec = FieldCodec.ForMessage<Quest>(106U, Quest.Parser);

		// Token: 0x040021BF RID: 8639
		private readonly RepeatedField<Quest> questList_ = new RepeatedField<Quest>();
	}
}
