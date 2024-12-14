using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AFD RID: 2813
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ModifyRelicFilterPlanCsReq : IMessage<ModifyRelicFilterPlanCsReq>, IMessage, IEquatable<ModifyRelicFilterPlanCsReq>, IDeepCloneable<ModifyRelicFilterPlanCsReq>, IBufferMessage
	{
		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x06007C71 RID: 31857 RVA: 0x00149683 File Offset: 0x00147883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ModifyRelicFilterPlanCsReq> Parser
		{
			get
			{
				return ModifyRelicFilterPlanCsReq._parser;
			}
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x06007C72 RID: 31858 RVA: 0x0014968A File Offset: 0x0014788A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ModifyRelicFilterPlanCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x0014969C File Offset: 0x0014789C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ModifyRelicFilterPlanCsReq.Descriptor;
			}
		}

		// Token: 0x06007C74 RID: 31860 RVA: 0x001496A3 File Offset: 0x001478A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyRelicFilterPlanCsReq()
		{
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x001496B8 File Offset: 0x001478B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyRelicFilterPlanCsReq(ModifyRelicFilterPlanCsReq other) : this()
		{
			this.slotIndex_ = other.slotIndex_;
			this.name_ = other.name_;
			this.icon_ = ((other.icon_ != null) ? other.icon_.Clone() : null);
			this.settings_ = ((other.settings_ != null) ? other.settings_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x0014972C File Offset: 0x0014792C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ModifyRelicFilterPlanCsReq Clone()
		{
			return new ModifyRelicFilterPlanCsReq(this);
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x00149734 File Offset: 0x00147934
		// (set) Token: 0x06007C78 RID: 31864 RVA: 0x0014973C File Offset: 0x0014793C
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

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x00149745 File Offset: 0x00147945
		// (set) Token: 0x06007C7A RID: 31866 RVA: 0x0014974D File Offset: 0x0014794D
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

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x06007C7B RID: 31867 RVA: 0x00149760 File Offset: 0x00147960
		// (set) Token: 0x06007C7C RID: 31868 RVA: 0x00149768 File Offset: 0x00147968
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

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x06007C7D RID: 31869 RVA: 0x00149771 File Offset: 0x00147971
		// (set) Token: 0x06007C7E RID: 31870 RVA: 0x00149779 File Offset: 0x00147979
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

		// Token: 0x06007C7F RID: 31871 RVA: 0x00149782 File Offset: 0x00147982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ModifyRelicFilterPlanCsReq);
		}

		// Token: 0x06007C80 RID: 31872 RVA: 0x00149790 File Offset: 0x00147990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ModifyRelicFilterPlanCsReq other)
		{
			return other != null && (other == this || (this.SlotIndex == other.SlotIndex && !(this.Name != other.Name) && object.Equals(this.Icon, other.Icon) && object.Equals(this.Settings, other.Settings) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x00149808 File Offset: 0x00147A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotIndex != 0U)
			{
				num ^= this.SlotIndex.GetHashCode();
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

		// Token: 0x06007C82 RID: 31874 RVA: 0x0014988E File Offset: 0x00147A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C83 RID: 31875 RVA: 0x00149896 File Offset: 0x00147A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x001498A0 File Offset: 0x00147AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.icon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Icon);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Name);
			}
			if (this.SlotIndex != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.SlotIndex);
			}
			if (this.settings_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Settings);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x00149938 File Offset: 0x00147B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SlotIndex);
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

		// Token: 0x06007C86 RID: 31878 RVA: 0x001499C4 File Offset: 0x00147BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ModifyRelicFilterPlanCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotIndex != 0U)
			{
				this.SlotIndex = other.SlotIndex;
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

		// Token: 0x06007C87 RID: 31879 RVA: 0x00149A71 File Offset: 0x00147C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x00149A7C File Offset: 0x00147C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 10U)
					{
						if (this.icon_ == null)
						{
							this.Icon = new RelicFilterPlanIcon();
						}
						input.ReadMessage(this.Icon);
						continue;
					}
					if (num == 42U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.SlotIndex = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.settings_ == null)
						{
							this.Settings = new RelicFilterPlanSettings();
						}
						input.ReadMessage(this.Settings);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FD4 RID: 12244
		private static readonly MessageParser<ModifyRelicFilterPlanCsReq> _parser = new MessageParser<ModifyRelicFilterPlanCsReq>(() => new ModifyRelicFilterPlanCsReq());

		// Token: 0x04002FD5 RID: 12245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FD6 RID: 12246
		public const int SlotIndexFieldNumber = 7;

		// Token: 0x04002FD7 RID: 12247
		private uint slotIndex_;

		// Token: 0x04002FD8 RID: 12248
		public const int NameFieldNumber = 5;

		// Token: 0x04002FD9 RID: 12249
		private string name_ = "";

		// Token: 0x04002FDA RID: 12250
		public const int IconFieldNumber = 1;

		// Token: 0x04002FDB RID: 12251
		private RelicFilterPlanIcon icon_;

		// Token: 0x04002FDC RID: 12252
		public const int SettingsFieldNumber = 15;

		// Token: 0x04002FDD RID: 12253
		private RelicFilterPlanSettings settings_;
	}
}
