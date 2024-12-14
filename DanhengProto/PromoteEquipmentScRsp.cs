using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D0F RID: 3343
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PromoteEquipmentScRsp : IMessage<PromoteEquipmentScRsp>, IMessage, IEquatable<PromoteEquipmentScRsp>, IDeepCloneable<PromoteEquipmentScRsp>, IBufferMessage
	{
		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x06009546 RID: 38214 RVA: 0x0018CC54 File Offset: 0x0018AE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PromoteEquipmentScRsp> Parser
		{
			get
			{
				return PromoteEquipmentScRsp._parser;
			}
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x06009547 RID: 38215 RVA: 0x0018CC5B File Offset: 0x0018AE5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PromoteEquipmentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x06009548 RID: 38216 RVA: 0x0018CC6D File Offset: 0x0018AE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PromoteEquipmentScRsp.Descriptor;
			}
		}

		// Token: 0x06009549 RID: 38217 RVA: 0x0018CC74 File Offset: 0x0018AE74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteEquipmentScRsp()
		{
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x0018CC7C File Offset: 0x0018AE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteEquipmentScRsp(PromoteEquipmentScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600954B RID: 38219 RVA: 0x0018CCA1 File Offset: 0x0018AEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PromoteEquipmentScRsp Clone()
		{
			return new PromoteEquipmentScRsp(this);
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x0600954C RID: 38220 RVA: 0x0018CCA9 File Offset: 0x0018AEA9
		// (set) Token: 0x0600954D RID: 38221 RVA: 0x0018CCB1 File Offset: 0x0018AEB1
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

		// Token: 0x0600954E RID: 38222 RVA: 0x0018CCBA File Offset: 0x0018AEBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PromoteEquipmentScRsp);
		}

		// Token: 0x0600954F RID: 38223 RVA: 0x0018CCC8 File Offset: 0x0018AEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PromoteEquipmentScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009550 RID: 38224 RVA: 0x0018CCF8 File Offset: 0x0018AEF8
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

		// Token: 0x06009551 RID: 38225 RVA: 0x0018CD37 File Offset: 0x0018AF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009552 RID: 38226 RVA: 0x0018CD3F File Offset: 0x0018AF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x0018CD48 File Offset: 0x0018AF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009554 RID: 38228 RVA: 0x0018CD7C File Offset: 0x0018AF7C
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

		// Token: 0x06009555 RID: 38229 RVA: 0x0018CDBA File Offset: 0x0018AFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PromoteEquipmentScRsp other)
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

		// Token: 0x06009556 RID: 38230 RVA: 0x0018CDEB File Offset: 0x0018AFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009557 RID: 38231 RVA: 0x0018CDF4 File Offset: 0x0018AFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040039DB RID: 14811
		private static readonly MessageParser<PromoteEquipmentScRsp> _parser = new MessageParser<PromoteEquipmentScRsp>(() => new PromoteEquipmentScRsp());

		// Token: 0x040039DC RID: 14812
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039DD RID: 14813
		public const int RetcodeFieldNumber = 10;

		// Token: 0x040039DE RID: 14814
		private uint retcode_;
	}
}
