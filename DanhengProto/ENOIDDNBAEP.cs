using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200042D RID: 1069
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ENOIDDNBAEP : IMessage<ENOIDDNBAEP>, IMessage, IEquatable<ENOIDDNBAEP>, IDeepCloneable<ENOIDDNBAEP>, IBufferMessage
	{
		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x00083074 File Offset: 0x00081274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ENOIDDNBAEP> Parser
		{
			get
			{
				return ENOIDDNBAEP._parser;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x0008307B File Offset: 0x0008127B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ENOIDDNBAEPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x0008308D File Offset: 0x0008128D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ENOIDDNBAEP.Descriptor;
			}
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00083094 File Offset: 0x00081294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENOIDDNBAEP()
		{
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x0008309C File Offset: 0x0008129C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENOIDDNBAEP(ENOIDDNBAEP other) : this()
		{
			this.cOJGEGHIADI_ = other.cOJGEGHIADI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x000830C1 File Offset: 0x000812C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENOIDDNBAEP Clone()
		{
			return new ENOIDDNBAEP(this);
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x000830C9 File Offset: 0x000812C9
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x000830D1 File Offset: 0x000812D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint COJGEGHIADI
		{
			get
			{
				return this.cOJGEGHIADI_;
			}
			set
			{
				this.cOJGEGHIADI_ = value;
			}
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x000830DA File Offset: 0x000812DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ENOIDDNBAEP);
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x000830E8 File Offset: 0x000812E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ENOIDDNBAEP other)
		{
			return other != null && (other == this || (this.COJGEGHIADI == other.COJGEGHIADI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x00083118 File Offset: 0x00081318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.COJGEGHIADI != 0U)
			{
				num ^= this.COJGEGHIADI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x00083157 File Offset: 0x00081357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x0008315F File Offset: 0x0008135F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00083168 File Offset: 0x00081368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.COJGEGHIADI != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x0008319C File Offset: 0x0008139C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.COJGEGHIADI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x000831DA File Offset: 0x000813DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ENOIDDNBAEP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.COJGEGHIADI != 0U)
			{
				this.COJGEGHIADI = other.COJGEGHIADI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x0008320B File Offset: 0x0008140B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x00083214 File Offset: 0x00081414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.COJGEGHIADI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001302 RID: 4866
		private static readonly MessageParser<ENOIDDNBAEP> _parser = new MessageParser<ENOIDDNBAEP>(() => new ENOIDDNBAEP());

		// Token: 0x04001303 RID: 4867
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001304 RID: 4868
		public const int COJGEGHIADIFieldNumber = 6;

		// Token: 0x04001305 RID: 4869
		private uint cOJGEGHIADI_;
	}
}
