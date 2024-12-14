using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001101 RID: 4353
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetGroupCustomSaveDataCsReq : IMessage<SetGroupCustomSaveDataCsReq>, IMessage, IEquatable<SetGroupCustomSaveDataCsReq>, IDeepCloneable<SetGroupCustomSaveDataCsReq>, IBufferMessage
	{
		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0600C217 RID: 49687 RVA: 0x00209815 File Offset: 0x00207A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetGroupCustomSaveDataCsReq> Parser
		{
			get
			{
				return SetGroupCustomSaveDataCsReq._parser;
			}
		}

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0600C218 RID: 49688 RVA: 0x0020981C File Offset: 0x00207A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetGroupCustomSaveDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x0600C219 RID: 49689 RVA: 0x0020982E File Offset: 0x00207A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetGroupCustomSaveDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600C21A RID: 49690 RVA: 0x00209835 File Offset: 0x00207A35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGroupCustomSaveDataCsReq()
		{
		}

		// Token: 0x0600C21B RID: 49691 RVA: 0x00209848 File Offset: 0x00207A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGroupCustomSaveDataCsReq(SetGroupCustomSaveDataCsReq other) : this()
		{
			this.saveData_ = other.saveData_;
			this.groupId_ = other.groupId_;
			this.entryId_ = other.entryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C21C RID: 49692 RVA: 0x00209885 File Offset: 0x00207A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGroupCustomSaveDataCsReq Clone()
		{
			return new SetGroupCustomSaveDataCsReq(this);
		}

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x0600C21D RID: 49693 RVA: 0x0020988D File Offset: 0x00207A8D
		// (set) Token: 0x0600C21E RID: 49694 RVA: 0x00209895 File Offset: 0x00207A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SaveData
		{
			get
			{
				return this.saveData_;
			}
			set
			{
				this.saveData_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x0600C21F RID: 49695 RVA: 0x002098A8 File Offset: 0x00207AA8
		// (set) Token: 0x0600C220 RID: 49696 RVA: 0x002098B0 File Offset: 0x00207AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x0600C221 RID: 49697 RVA: 0x002098B9 File Offset: 0x00207AB9
		// (set) Token: 0x0600C222 RID: 49698 RVA: 0x002098C1 File Offset: 0x00207AC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntryId
		{
			get
			{
				return this.entryId_;
			}
			set
			{
				this.entryId_ = value;
			}
		}

		// Token: 0x0600C223 RID: 49699 RVA: 0x002098CA File Offset: 0x00207ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetGroupCustomSaveDataCsReq);
		}

		// Token: 0x0600C224 RID: 49700 RVA: 0x002098D8 File Offset: 0x00207AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetGroupCustomSaveDataCsReq other)
		{
			return other != null && (other == this || (!(this.SaveData != other.SaveData) && this.GroupId == other.GroupId && this.EntryId == other.EntryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C225 RID: 49701 RVA: 0x00209938 File Offset: 0x00207B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SaveData.Length != 0)
			{
				num ^= this.SaveData.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.EntryId != 0U)
			{
				num ^= this.EntryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C226 RID: 49702 RVA: 0x002099AB File Offset: 0x00207BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C227 RID: 49703 RVA: 0x002099B3 File Offset: 0x00207BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C228 RID: 49704 RVA: 0x002099BC File Offset: 0x00207BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntryId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EntryId);
			}
			if (this.SaveData.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.SaveData);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C229 RID: 49705 RVA: 0x00209A38 File Offset: 0x00207C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SaveData.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SaveData);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.EntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C22A RID: 49706 RVA: 0x00209AAC File Offset: 0x00207CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetGroupCustomSaveDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SaveData.Length != 0)
			{
				this.SaveData = other.SaveData;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.EntryId != 0U)
			{
				this.EntryId = other.EntryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C22B RID: 49707 RVA: 0x00209B15 File Offset: 0x00207D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C22C RID: 49708 RVA: 0x00209B20 File Offset: 0x00207D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 82U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GroupId = input.ReadUInt32();
						}
					}
					else
					{
						this.SaveData = input.ReadString();
					}
				}
				else
				{
					this.EntryId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E8C RID: 20108
		private static readonly MessageParser<SetGroupCustomSaveDataCsReq> _parser = new MessageParser<SetGroupCustomSaveDataCsReq>(() => new SetGroupCustomSaveDataCsReq());

		// Token: 0x04004E8D RID: 20109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E8E RID: 20110
		public const int SaveDataFieldNumber = 10;

		// Token: 0x04004E8F RID: 20111
		private string saveData_ = "";

		// Token: 0x04004E90 RID: 20112
		public const int GroupIdFieldNumber = 14;

		// Token: 0x04004E91 RID: 20113
		private uint groupId_;

		// Token: 0x04004E92 RID: 20114
		public const int EntryIdFieldNumber = 6;

		// Token: 0x04004E93 RID: 20115
		private uint entryId_;
	}
}
