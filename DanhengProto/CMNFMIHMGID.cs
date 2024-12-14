using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200030B RID: 779
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CMNFMIHMGID : IMessage<CMNFMIHMGID>, IMessage, IEquatable<CMNFMIHMGID>, IDeepCloneable<CMNFMIHMGID>, IBufferMessage
	{
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x00063780 File Offset: 0x00061980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CMNFMIHMGID> Parser
		{
			get
			{
				return CMNFMIHMGID._parser;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x00063787 File Offset: 0x00061987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CMNFMIHMGIDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x00063799 File Offset: 0x00061999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CMNFMIHMGID.Descriptor;
			}
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x000637A0 File Offset: 0x000619A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CMNFMIHMGID()
		{
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x000637A8 File Offset: 0x000619A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CMNFMIHMGID(CMNFMIHMGID other) : this()
		{
			this.eFKKIADEFFI_ = other.eFKKIADEFFI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x000637CD File Offset: 0x000619CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CMNFMIHMGID Clone()
		{
			return new CMNFMIHMGID(this);
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x000637D5 File Offset: 0x000619D5
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x000637DD File Offset: 0x000619DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EFKKIADEFFI
		{
			get
			{
				return this.eFKKIADEFFI_;
			}
			set
			{
				this.eFKKIADEFFI_ = value;
			}
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x000637E6 File Offset: 0x000619E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CMNFMIHMGID);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x000637F4 File Offset: 0x000619F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CMNFMIHMGID other)
		{
			return other != null && (other == this || (this.EFKKIADEFFI == other.EFKKIADEFFI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00063824 File Offset: 0x00061A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EFKKIADEFFI)
			{
				num ^= this.EFKKIADEFFI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00063863 File Offset: 0x00061A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0006386B File Offset: 0x00061A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00063874 File Offset: 0x00061A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EFKKIADEFFI)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.EFKKIADEFFI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000638A8 File Offset: 0x00061AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EFKKIADEFFI)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x000638DA File Offset: 0x00061ADA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CMNFMIHMGID other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EFKKIADEFFI)
			{
				this.EFKKIADEFFI = other.EFKKIADEFFI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x0006390B File Offset: 0x00061B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00063914 File Offset: 0x00061B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EFKKIADEFFI = input.ReadBool();
				}
			}
		}

		// Token: 0x04000E68 RID: 3688
		private static readonly MessageParser<CMNFMIHMGID> _parser = new MessageParser<CMNFMIHMGID>(() => new CMNFMIHMGID());

		// Token: 0x04000E69 RID: 3689
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E6A RID: 3690
		public const int EFKKIADEFFIFieldNumber = 1;

		// Token: 0x04000E6B RID: 3691
		private bool eFKKIADEFFI_;
	}
}
