using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C6D RID: 3181
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OpenRogueChestScRsp : IMessage<OpenRogueChestScRsp>, IMessage, IEquatable<OpenRogueChestScRsp>, IDeepCloneable<OpenRogueChestScRsp>, IBufferMessage
	{
		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x06008D5D RID: 36189 RVA: 0x00175B21 File Offset: 0x00173D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OpenRogueChestScRsp> Parser
		{
			get
			{
				return OpenRogueChestScRsp._parser;
			}
		}

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x06008D5E RID: 36190 RVA: 0x00175B28 File Offset: 0x00173D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OpenRogueChestScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x06008D5F RID: 36191 RVA: 0x00175B3A File Offset: 0x00173D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenRogueChestScRsp.Descriptor;
			}
		}

		// Token: 0x06008D60 RID: 36192 RVA: 0x00175B41 File Offset: 0x00173D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenRogueChestScRsp()
		{
		}

		// Token: 0x06008D61 RID: 36193 RVA: 0x00175B4C File Offset: 0x00173D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenRogueChestScRsp(OpenRogueChestScRsp other) : this()
		{
			this.dropData_ = ((other.dropData_ != null) ? other.dropData_.Clone() : null);
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D62 RID: 36194 RVA: 0x00175BB4 File Offset: 0x00173DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenRogueChestScRsp Clone()
		{
			return new OpenRogueChestScRsp(this);
		}

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x06008D63 RID: 36195 RVA: 0x00175BBC File Offset: 0x00173DBC
		// (set) Token: 0x06008D64 RID: 36196 RVA: 0x00175BC4 File Offset: 0x00173DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList DropData
		{
			get
			{
				return this.dropData_;
			}
			set
			{
				this.dropData_ = value;
			}
		}

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x06008D65 RID: 36197 RVA: 0x00175BCD File Offset: 0x00173DCD
		// (set) Token: 0x06008D66 RID: 36198 RVA: 0x00175BD5 File Offset: 0x00173DD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x06008D67 RID: 36199 RVA: 0x00175BDE File Offset: 0x00173DDE
		// (set) Token: 0x06008D68 RID: 36200 RVA: 0x00175BE6 File Offset: 0x00173DE6
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

		// Token: 0x06008D69 RID: 36201 RVA: 0x00175BEF File Offset: 0x00173DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenRogueChestScRsp);
		}

		// Token: 0x06008D6A RID: 36202 RVA: 0x00175C00 File Offset: 0x00173E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OpenRogueChestScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.DropData, other.DropData) && object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D6B RID: 36203 RVA: 0x00175C64 File Offset: 0x00173E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dropData_ != null)
			{
				num ^= this.DropData.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D6C RID: 36204 RVA: 0x00175CCF File Offset: 0x00173ECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D6D RID: 36205 RVA: 0x00175CD7 File Offset: 0x00173ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D6E RID: 36206 RVA: 0x00175CE0 File Offset: 0x00173EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Reward);
			}
			if (this.dropData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.DropData);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x00175D58 File Offset: 0x00173F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dropData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DropData);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D70 RID: 36208 RVA: 0x00175DC8 File Offset: 0x00173FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OpenRogueChestScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.dropData_ != null)
			{
				if (this.dropData_ == null)
				{
					this.DropData = new ItemList();
				}
				this.DropData.MergeFrom(other.DropData);
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D71 RID: 36209 RVA: 0x00175E5C File Offset: 0x0017405C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D72 RID: 36210 RVA: 0x00175E68 File Offset: 0x00174068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 74U)
					{
						if (num != 104U)
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
						if (this.dropData_ == null)
						{
							this.DropData = new ItemList();
						}
						input.ReadMessage(this.DropData);
					}
				}
				else
				{
					if (this.reward_ == null)
					{
						this.Reward = new ItemList();
					}
					input.ReadMessage(this.Reward);
				}
			}
		}

		// Token: 0x0400364D RID: 13901
		private static readonly MessageParser<OpenRogueChestScRsp> _parser = new MessageParser<OpenRogueChestScRsp>(() => new OpenRogueChestScRsp());

		// Token: 0x0400364E RID: 13902
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400364F RID: 13903
		public const int DropDataFieldNumber = 9;

		// Token: 0x04003650 RID: 13904
		private ItemList dropData_;

		// Token: 0x04003651 RID: 13905
		public const int RewardFieldNumber = 5;

		// Token: 0x04003652 RID: 13906
		private ItemList reward_;

		// Token: 0x04003653 RID: 13907
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04003654 RID: 13908
		private uint retcode_;
	}
}
