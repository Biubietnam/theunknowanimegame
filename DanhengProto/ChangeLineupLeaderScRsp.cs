using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001C9 RID: 457
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChangeLineupLeaderScRsp : IMessage<ChangeLineupLeaderScRsp>, IMessage, IEquatable<ChangeLineupLeaderScRsp>, IDeepCloneable<ChangeLineupLeaderScRsp>, IBufferMessage
	{
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0003AF74 File Offset: 0x00039174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChangeLineupLeaderScRsp> Parser
		{
			get
			{
				return ChangeLineupLeaderScRsp._parser;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0003AF7B File Offset: 0x0003917B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChangeLineupLeaderScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0003AF8D File Offset: 0x0003918D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeLineupLeaderScRsp.Descriptor;
			}
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0003AF94 File Offset: 0x00039194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeLineupLeaderScRsp()
		{
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0003AF9C File Offset: 0x0003919C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeLineupLeaderScRsp(ChangeLineupLeaderScRsp other) : this()
		{
			this.slot_ = other.slot_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0003AFCD File Offset: 0x000391CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeLineupLeaderScRsp Clone()
		{
			return new ChangeLineupLeaderScRsp(this);
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0003AFD5 File Offset: 0x000391D5
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x0003AFDD File Offset: 0x000391DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0003AFE6 File Offset: 0x000391E6
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x0003AFEE File Offset: 0x000391EE
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

		// Token: 0x06001494 RID: 5268 RVA: 0x0003AFF7 File Offset: 0x000391F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeLineupLeaderScRsp);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0003B005 File Offset: 0x00039205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeLineupLeaderScRsp other)
		{
			return other != null && (other == this || (this.Slot == other.Slot && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0003B044 File Offset: 0x00039244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Slot != 0U)
			{
				num ^= this.Slot.GetHashCode();
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

		// Token: 0x06001497 RID: 5271 RVA: 0x0003B09C File Offset: 0x0003929C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0003B0A4 File Offset: 0x000392A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0003B0B0 File Offset: 0x000392B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Slot != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Slot);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0003B10C File Offset: 0x0003930C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Slot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Slot);
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

		// Token: 0x0600149B RID: 5275 RVA: 0x0003B164 File Offset: 0x00039364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeLineupLeaderScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0003B1B4 File Offset: 0x000393B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0003B1C0 File Offset: 0x000393C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 96U)
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
					this.Slot = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400089B RID: 2203
		private static readonly MessageParser<ChangeLineupLeaderScRsp> _parser = new MessageParser<ChangeLineupLeaderScRsp>(() => new ChangeLineupLeaderScRsp());

		// Token: 0x0400089C RID: 2204
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400089D RID: 2205
		public const int SlotFieldNumber = 4;

		// Token: 0x0400089E RID: 2206
		private uint slot_;

		// Token: 0x0400089F RID: 2207
		public const int RetcodeFieldNumber = 12;

		// Token: 0x040008A0 RID: 2208
		private uint retcode_;
	}
}
