using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A8F RID: 2703
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MarkReadMailScRsp : IMessage<MarkReadMailScRsp>, IMessage, IEquatable<MarkReadMailScRsp>, IDeepCloneable<MarkReadMailScRsp>, IBufferMessage
	{
		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x060077D5 RID: 30677 RVA: 0x0013DB18 File Offset: 0x0013BD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkReadMailScRsp> Parser
		{
			get
			{
				return MarkReadMailScRsp._parser;
			}
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x060077D6 RID: 30678 RVA: 0x0013DB1F File Offset: 0x0013BD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MarkReadMailScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x060077D7 RID: 30679 RVA: 0x0013DB31 File Offset: 0x0013BD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkReadMailScRsp.Descriptor;
			}
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x0013DB38 File Offset: 0x0013BD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkReadMailScRsp()
		{
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x0013DB40 File Offset: 0x0013BD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkReadMailScRsp(MarkReadMailScRsp other) : this()
		{
			this.id_ = other.id_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x0013DB71 File Offset: 0x0013BD71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkReadMailScRsp Clone()
		{
			return new MarkReadMailScRsp(this);
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x060077DB RID: 30683 RVA: 0x0013DB79 File Offset: 0x0013BD79
		// (set) Token: 0x060077DC RID: 30684 RVA: 0x0013DB81 File Offset: 0x0013BD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x060077DD RID: 30685 RVA: 0x0013DB8A File Offset: 0x0013BD8A
		// (set) Token: 0x060077DE RID: 30686 RVA: 0x0013DB92 File Offset: 0x0013BD92
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

		// Token: 0x060077DF RID: 30687 RVA: 0x0013DB9B File Offset: 0x0013BD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkReadMailScRsp);
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x0013DBA9 File Offset: 0x0013BDA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkReadMailScRsp other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x0013DBE8 File Offset: 0x0013BDE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
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

		// Token: 0x060077E2 RID: 30690 RVA: 0x0013DC40 File Offset: 0x0013BE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x0013DC48 File Offset: 0x0013BE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x0013DC54 File Offset: 0x0013BE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x0013DCB0 File Offset: 0x0013BEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
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

		// Token: 0x060077E6 RID: 30694 RVA: 0x0013DD08 File Offset: 0x0013BF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkReadMailScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x0013DD58 File Offset: 0x0013BF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x0013DD64 File Offset: 0x0013BF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002DFD RID: 11773
		private static readonly MessageParser<MarkReadMailScRsp> _parser = new MessageParser<MarkReadMailScRsp>(() => new MarkReadMailScRsp());

		// Token: 0x04002DFE RID: 11774
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DFF RID: 11775
		public const int IdFieldNumber = 5;

		// Token: 0x04002E00 RID: 11776
		private uint id_;

		// Token: 0x04002E01 RID: 11777
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04002E02 RID: 11778
		private uint retcode_;
	}
}
