using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009FB RID: 2555
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveRaidCsReq : IMessage<LeaveRaidCsReq>, IMessage, IEquatable<LeaveRaidCsReq>, IDeepCloneable<LeaveRaidCsReq>, IBufferMessage
	{
		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06007165 RID: 29029 RVA: 0x0012DDF0 File Offset: 0x0012BFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveRaidCsReq> Parser
		{
			get
			{
				return LeaveRaidCsReq._parser;
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06007166 RID: 29030 RVA: 0x0012DDF7 File Offset: 0x0012BFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveRaidCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06007167 RID: 29031 RVA: 0x0012DE09 File Offset: 0x0012C009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveRaidCsReq.Descriptor;
			}
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x0012DE10 File Offset: 0x0012C010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRaidCsReq()
		{
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x0012DE18 File Offset: 0x0012C018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRaidCsReq(LeaveRaidCsReq other) : this()
		{
			this.raidId_ = other.raidId_;
			this.isSaveData_ = other.isSaveData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x0012DE49 File Offset: 0x0012C049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRaidCsReq Clone()
		{
			return new LeaveRaidCsReq(this);
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x0600716B RID: 29035 RVA: 0x0012DE51 File Offset: 0x0012C051
		// (set) Token: 0x0600716C RID: 29036 RVA: 0x0012DE59 File Offset: 0x0012C059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RaidId
		{
			get
			{
				return this.raidId_;
			}
			set
			{
				this.raidId_ = value;
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x0600716D RID: 29037 RVA: 0x0012DE62 File Offset: 0x0012C062
		// (set) Token: 0x0600716E RID: 29038 RVA: 0x0012DE6A File Offset: 0x0012C06A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSaveData
		{
			get
			{
				return this.isSaveData_;
			}
			set
			{
				this.isSaveData_ = value;
			}
		}

		// Token: 0x0600716F RID: 29039 RVA: 0x0012DE73 File Offset: 0x0012C073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveRaidCsReq);
		}

		// Token: 0x06007170 RID: 29040 RVA: 0x0012DE81 File Offset: 0x0012C081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveRaidCsReq other)
		{
			return other != null && (other == this || (this.RaidId == other.RaidId && this.IsSaveData == other.IsSaveData && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007171 RID: 29041 RVA: 0x0012DEC0 File Offset: 0x0012C0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			if (this.IsSaveData)
			{
				num ^= this.IsSaveData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007172 RID: 29042 RVA: 0x0012DF18 File Offset: 0x0012C118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x0012DF20 File Offset: 0x0012C120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x0012DF2C File Offset: 0x0012C12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSaveData)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsSaveData);
			}
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.RaidId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x0012DF88 File Offset: 0x0012C188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			if (this.IsSaveData)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007176 RID: 29046 RVA: 0x0012DFD4 File Offset: 0x0012C1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveRaidCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			if (other.IsSaveData)
			{
				this.IsSaveData = other.IsSaveData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x0012E024 File Offset: 0x0012C224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007178 RID: 29048 RVA: 0x0012E030 File Offset: 0x0012C230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RaidId = input.ReadUInt32();
					}
				}
				else
				{
					this.IsSaveData = input.ReadBool();
				}
			}
		}

		// Token: 0x04002BA0 RID: 11168
		private static readonly MessageParser<LeaveRaidCsReq> _parser = new MessageParser<LeaveRaidCsReq>(() => new LeaveRaidCsReq());

		// Token: 0x04002BA1 RID: 11169
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BA2 RID: 11170
		public const int RaidIdFieldNumber = 6;

		// Token: 0x04002BA3 RID: 11171
		private uint raidId_;

		// Token: 0x04002BA4 RID: 11172
		public const int IsSaveDataFieldNumber = 3;

		// Token: 0x04002BA5 RID: 11173
		private bool isSaveData_;
	}
}
