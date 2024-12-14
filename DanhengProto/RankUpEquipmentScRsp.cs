using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D7B RID: 3451
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RankUpEquipmentScRsp : IMessage<RankUpEquipmentScRsp>, IMessage, IEquatable<RankUpEquipmentScRsp>, IDeepCloneable<RankUpEquipmentScRsp>, IBufferMessage
	{
		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x06009A2D RID: 39469 RVA: 0x0019A77C File Offset: 0x0019897C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RankUpEquipmentScRsp> Parser
		{
			get
			{
				return RankUpEquipmentScRsp._parser;
			}
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x06009A2E RID: 39470 RVA: 0x0019A783 File Offset: 0x00198983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RankUpEquipmentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x06009A2F RID: 39471 RVA: 0x0019A795 File Offset: 0x00198995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RankUpEquipmentScRsp.Descriptor;
			}
		}

		// Token: 0x06009A30 RID: 39472 RVA: 0x0019A79C File Offset: 0x0019899C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpEquipmentScRsp()
		{
		}

		// Token: 0x06009A31 RID: 39473 RVA: 0x0019A7A4 File Offset: 0x001989A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpEquipmentScRsp(RankUpEquipmentScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A32 RID: 39474 RVA: 0x0019A7C9 File Offset: 0x001989C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpEquipmentScRsp Clone()
		{
			return new RankUpEquipmentScRsp(this);
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x06009A33 RID: 39475 RVA: 0x0019A7D1 File Offset: 0x001989D1
		// (set) Token: 0x06009A34 RID: 39476 RVA: 0x0019A7D9 File Offset: 0x001989D9
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

		// Token: 0x06009A35 RID: 39477 RVA: 0x0019A7E2 File Offset: 0x001989E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RankUpEquipmentScRsp);
		}

		// Token: 0x06009A36 RID: 39478 RVA: 0x0019A7F0 File Offset: 0x001989F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RankUpEquipmentScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A37 RID: 39479 RVA: 0x0019A820 File Offset: 0x00198A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06009A38 RID: 39480 RVA: 0x0019A85F File Offset: 0x00198A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A39 RID: 39481 RVA: 0x0019A867 File Offset: 0x00198A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A3A RID: 39482 RVA: 0x0019A870 File Offset: 0x00198A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A3B RID: 39483 RVA: 0x0019A8A4 File Offset: 0x00198AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06009A3C RID: 39484 RVA: 0x0019A8E2 File Offset: 0x00198AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RankUpEquipmentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A3D RID: 39485 RVA: 0x0019A913 File Offset: 0x00198B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A3E RID: 39486 RVA: 0x0019A91C File Offset: 0x00198B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003BDE RID: 15326
		private static readonly MessageParser<RankUpEquipmentScRsp> _parser = new MessageParser<RankUpEquipmentScRsp>(() => new RankUpEquipmentScRsp());

		// Token: 0x04003BDF RID: 15327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BE0 RID: 15328
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04003BE1 RID: 15329
		private uint retcode_;
	}
}
