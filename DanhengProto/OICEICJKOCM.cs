using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C51 RID: 3153
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OICEICJKOCM : IMessage<OICEICJKOCM>, IMessage, IEquatable<OICEICJKOCM>, IDeepCloneable<OICEICJKOCM>, IBufferMessage
	{
		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x06008BF8 RID: 35832 RVA: 0x00171EF0 File Offset: 0x001700F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OICEICJKOCM> Parser
		{
			get
			{
				return OICEICJKOCM._parser;
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x06008BF9 RID: 35833 RVA: 0x00171EF7 File Offset: 0x001700F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OICEICJKOCMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x06008BFA RID: 35834 RVA: 0x00171F09 File Offset: 0x00170109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OICEICJKOCM.Descriptor;
			}
		}

		// Token: 0x06008BFB RID: 35835 RVA: 0x00171F10 File Offset: 0x00170110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OICEICJKOCM()
		{
		}

		// Token: 0x06008BFC RID: 35836 RVA: 0x00171F18 File Offset: 0x00170118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OICEICJKOCM(OICEICJKOCM other) : this()
		{
			this.fCAAGLKFAID_ = other.fCAAGLKFAID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008BFD RID: 35837 RVA: 0x00171F3D File Offset: 0x0017013D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OICEICJKOCM Clone()
		{
			return new OICEICJKOCM(this);
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x06008BFE RID: 35838 RVA: 0x00171F45 File Offset: 0x00170145
		// (set) Token: 0x06008BFF RID: 35839 RVA: 0x00171F4D File Offset: 0x0017014D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FCAAGLKFAID
		{
			get
			{
				return this.fCAAGLKFAID_;
			}
			set
			{
				this.fCAAGLKFAID_ = value;
			}
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x00171F56 File Offset: 0x00170156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OICEICJKOCM);
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x00171F64 File Offset: 0x00170164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OICEICJKOCM other)
		{
			return other != null && (other == this || (this.FCAAGLKFAID == other.FCAAGLKFAID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x00171F94 File Offset: 0x00170194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FCAAGLKFAID != 0U)
			{
				num ^= this.FCAAGLKFAID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x00171FD3 File Offset: 0x001701D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x00171FDB File Offset: 0x001701DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C05 RID: 35845 RVA: 0x00171FE4 File Offset: 0x001701E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FCAAGLKFAID != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.FCAAGLKFAID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C06 RID: 35846 RVA: 0x00172018 File Offset: 0x00170218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FCAAGLKFAID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FCAAGLKFAID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C07 RID: 35847 RVA: 0x00172056 File Offset: 0x00170256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OICEICJKOCM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FCAAGLKFAID != 0U)
			{
				this.FCAAGLKFAID = other.FCAAGLKFAID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C08 RID: 35848 RVA: 0x00172087 File Offset: 0x00170287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C09 RID: 35849 RVA: 0x00172090 File Offset: 0x00170290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FCAAGLKFAID = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040035BE RID: 13758
		private static readonly MessageParser<OICEICJKOCM> _parser = new MessageParser<OICEICJKOCM>(() => new OICEICJKOCM());

		// Token: 0x040035BF RID: 13759
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035C0 RID: 13760
		public const int FCAAGLKFAIDFieldNumber = 5;

		// Token: 0x040035C1 RID: 13761
		private uint fCAAGLKFAID_;
	}
}
