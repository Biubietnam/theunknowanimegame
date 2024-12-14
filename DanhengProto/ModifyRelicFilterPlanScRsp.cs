using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AFF RID: 2815
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ModifyRelicFilterPlanScRsp : IMessage<ModifyRelicFilterPlanScRsp>, IMessage, IEquatable<ModifyRelicFilterPlanScRsp>, IDeepCloneable<ModifyRelicFilterPlanScRsp>, IBufferMessage
	{
		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x06007C8C RID: 31884 RVA: 0x00149C27 File Offset: 0x00147E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ModifyRelicFilterPlanScRsp> Parser
		{
			get
			{
				return ModifyRelicFilterPlanScRsp._parser;
			}
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x06007C8D RID: 31885 RVA: 0x00149C2E File Offset: 0x00147E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ModifyRelicFilterPlanScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x06007C8E RID: 31886 RVA: 0x00149C40 File Offset: 0x00147E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyRelicFilterPlanScRsp.Descriptor;
			}
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x00149C47 File Offset: 0x00147E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyRelicFilterPlanScRsp()
		{
		}

		// Token: 0x06007C90 RID: 31888 RVA: 0x00149C5C File Offset: 0x00147E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyRelicFilterPlanScRsp(ModifyRelicFilterPlanScRsp other) : this()
		{
			this.updateTimestamp_ = other.updateTimestamp_;
			this.slotIndex_ = other.slotIndex_;
			this.retcode_ = other.retcode_;
			this.name_ = other.name_;
			this.icon_ = ((other.icon_ != null) ? other.icon_.Clone() : null);
			this.settings_ = ((other.settings_ != null) ? other.settings_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x00149CE8 File Offset: 0x00147EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyRelicFilterPlanScRsp Clone()
		{
			return new ModifyRelicFilterPlanScRsp(this);
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x06007C92 RID: 31890 RVA: 0x00149CF0 File Offset: 0x00147EF0
		// (set) Token: 0x06007C93 RID: 31891 RVA: 0x00149CF8 File Offset: 0x00147EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UpdateTimestamp
		{
			get
			{
				return this.updateTimestamp_;
			}
			set
			{
				this.updateTimestamp_ = value;
			}
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x06007C94 RID: 31892 RVA: 0x00149D01 File Offset: 0x00147F01
		// (set) Token: 0x06007C95 RID: 31893 RVA: 0x00149D09 File Offset: 0x00147F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SlotIndex
		{
			get
			{
				return this.slotIndex_;
			}
			set
			{
				this.slotIndex_ = value;
			}
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x06007C96 RID: 31894 RVA: 0x00149D12 File Offset: 0x00147F12
		// (set) Token: 0x06007C97 RID: 31895 RVA: 0x00149D1A File Offset: 0x00147F1A
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

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x06007C98 RID: 31896 RVA: 0x00149D23 File Offset: 0x00147F23
		// (set) Token: 0x06007C99 RID: 31897 RVA: 0x00149D2B File Offset: 0x00147F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170022FF RID: 8959
		// (get) Token: 0x06007C9A RID: 31898 RVA: 0x00149D3E File Offset: 0x00147F3E
		// (set) Token: 0x06007C9B RID: 31899 RVA: 0x00149D46 File Offset: 0x00147F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanIcon Icon
		{
			get
			{
				return this.icon_;
			}
			set
			{
				this.icon_ = value;
			}
		}

		// Token: 0x17002300 RID: 8960
		// (get) Token: 0x06007C9C RID: 31900 RVA: 0x00149D4F File Offset: 0x00147F4F
		// (set) Token: 0x06007C9D RID: 31901 RVA: 0x00149D57 File Offset: 0x00147F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanSettings Settings
		{
			get
			{
				return this.settings_;
			}
			set
			{
				this.settings_ = value;
			}
		}

		// Token: 0x06007C9E RID: 31902 RVA: 0x00149D60 File Offset: 0x00147F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyRelicFilterPlanScRsp);
		}

		// Token: 0x06007C9F RID: 31903 RVA: 0x00149D70 File Offset: 0x00147F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyRelicFilterPlanScRsp other)
		{
			return other != null && (other == this || (this.UpdateTimestamp == other.UpdateTimestamp && this.SlotIndex == other.SlotIndex && this.Retcode == other.Retcode && !(this.Name != other.Name) && object.Equals(this.Icon, other.Icon) && object.Equals(this.Settings, other.Settings) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x00149E08 File Offset: 0x00148008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UpdateTimestamp != 0L)
			{
				num ^= this.UpdateTimestamp.GetHashCode();
			}
			if (this.SlotIndex != 0U)
			{
				num ^= this.SlotIndex.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.icon_ != null)
			{
				num ^= this.Icon.GetHashCode();
			}
			if (this.settings_ != null)
			{
				num ^= this.Settings.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x00149EC0 File Offset: 0x001480C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x00149EC8 File Offset: 0x001480C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x00149ED4 File Offset: 0x001480D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Name);
			}
			if (this.icon_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Icon);
			}
			if (this.SlotIndex != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.SlotIndex);
			}
			if (this.UpdateTimestamp != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.UpdateTimestamp);
			}
			if (this.settings_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Settings);
			}
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

		// Token: 0x06007CA4 RID: 31908 RVA: 0x00149FA4 File Offset: 0x001481A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UpdateTimestamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UpdateTimestamp);
			}
			if (this.SlotIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SlotIndex);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.icon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Icon);
			}
			if (this.settings_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Settings);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x0014A060 File Offset: 0x00148260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyRelicFilterPlanScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UpdateTimestamp != 0L)
			{
				this.UpdateTimestamp = other.UpdateTimestamp;
			}
			if (other.SlotIndex != 0U)
			{
				this.SlotIndex = other.SlotIndex;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.icon_ != null)
			{
				if (this.icon_ == null)
				{
					this.Icon = new RelicFilterPlanIcon();
				}
				this.Icon.MergeFrom(other.Icon);
			}
			if (other.settings_ != null)
			{
				if (this.settings_ == null)
				{
					this.Settings = new RelicFilterPlanSettings();
				}
				this.Settings.MergeFrom(other.Settings);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x0014A135 File Offset: 0x00148335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x0014A140 File Offset: 0x00148340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 96U)
				{
					if (num == 18U)
					{
						this.Name = input.ReadString();
						continue;
					}
					if (num == 66U)
					{
						if (this.icon_ == null)
						{
							this.Icon = new RelicFilterPlanIcon();
						}
						input.ReadMessage(this.Icon);
						continue;
					}
					if (num == 96U)
					{
						this.SlotIndex = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.UpdateTimestamp = input.ReadInt64();
						continue;
					}
					if (num == 114U)
					{
						if (this.settings_ == null)
						{
							this.Settings = new RelicFilterPlanSettings();
						}
						input.ReadMessage(this.Settings);
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FDF RID: 12255
		private static readonly MessageParser<ModifyRelicFilterPlanScRsp> _parser = new MessageParser<ModifyRelicFilterPlanScRsp>(() => new ModifyRelicFilterPlanScRsp());

		// Token: 0x04002FE0 RID: 12256
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FE1 RID: 12257
		public const int UpdateTimestampFieldNumber = 13;

		// Token: 0x04002FE2 RID: 12258
		private long updateTimestamp_;

		// Token: 0x04002FE3 RID: 12259
		public const int SlotIndexFieldNumber = 12;

		// Token: 0x04002FE4 RID: 12260
		private uint slotIndex_;

		// Token: 0x04002FE5 RID: 12261
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04002FE6 RID: 12262
		private uint retcode_;

		// Token: 0x04002FE7 RID: 12263
		public const int NameFieldNumber = 2;

		// Token: 0x04002FE8 RID: 12264
		private string name_ = "";

		// Token: 0x04002FE9 RID: 12265
		public const int IconFieldNumber = 8;

		// Token: 0x04002FEA RID: 12266
		private RelicFilterPlanIcon icon_;

		// Token: 0x04002FEB RID: 12267
		public const int SettingsFieldNumber = 14;

		// Token: 0x04002FEC RID: 12268
		private RelicFilterPlanSettings settings_;
	}
}
