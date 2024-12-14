using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200095D RID: 2397
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JDGBFNHLADP : IMessage<JDGBFNHLADP>, IMessage, IEquatable<JDGBFNHLADP>, IDeepCloneable<JDGBFNHLADP>, IBufferMessage
	{
		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x06006B0C RID: 27404 RVA: 0x0011D859 File Offset: 0x0011BA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JDGBFNHLADP> Parser
		{
			get
			{
				return JDGBFNHLADP._parser;
			}
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x06006B0D RID: 27405 RVA: 0x0011D860 File Offset: 0x0011BA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JDGBFNHLADPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x06006B0E RID: 27406 RVA: 0x0011D872 File Offset: 0x0011BA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JDGBFNHLADP.Descriptor;
			}
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x0011D879 File Offset: 0x0011BA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDGBFNHLADP()
		{
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x0011D881 File Offset: 0x0011BA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDGBFNHLADP(JDGBFNHLADP other) : this()
		{
			this.pBMCHBOMDHL_ = ((other.pBMCHBOMDHL_ != null) ? other.pBMCHBOMDHL_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B11 RID: 27409 RVA: 0x0011D8B6 File Offset: 0x0011BAB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDGBFNHLADP Clone()
		{
			return new JDGBFNHLADP(this);
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x06006B12 RID: 27410 RVA: 0x0011D8BE File Offset: 0x0011BABE
		// (set) Token: 0x06006B13 RID: 27411 RVA: 0x0011D8C6 File Offset: 0x0011BAC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepter PBMCHBOMDHL
		{
			get
			{
				return this.pBMCHBOMDHL_;
			}
			set
			{
				this.pBMCHBOMDHL_ = value;
			}
		}

		// Token: 0x06006B14 RID: 27412 RVA: 0x0011D8CF File Offset: 0x0011BACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JDGBFNHLADP);
		}

		// Token: 0x06006B15 RID: 27413 RVA: 0x0011D8DD File Offset: 0x0011BADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JDGBFNHLADP other)
		{
			return other != null && (other == this || (object.Equals(this.PBMCHBOMDHL, other.PBMCHBOMDHL) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B16 RID: 27414 RVA: 0x0011D910 File Offset: 0x0011BB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pBMCHBOMDHL_ != null)
			{
				num ^= this.PBMCHBOMDHL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B17 RID: 27415 RVA: 0x0011D94C File Offset: 0x0011BB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B18 RID: 27416 RVA: 0x0011D954 File Offset: 0x0011BB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B19 RID: 27417 RVA: 0x0011D95D File Offset: 0x0011BB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pBMCHBOMDHL_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PBMCHBOMDHL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B1A RID: 27418 RVA: 0x0011D990 File Offset: 0x0011BB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pBMCHBOMDHL_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PBMCHBOMDHL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B1B RID: 27419 RVA: 0x0011D9D0 File Offset: 0x0011BBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JDGBFNHLADP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pBMCHBOMDHL_ != null)
			{
				if (this.pBMCHBOMDHL_ == null)
				{
					this.PBMCHBOMDHL = new RogueMagicScepter();
				}
				this.PBMCHBOMDHL.MergeFrom(other.PBMCHBOMDHL);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B1C RID: 27420 RVA: 0x0011DA24 File Offset: 0x0011BC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B1D RID: 27421 RVA: 0x0011DA30 File Offset: 0x0011BC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.pBMCHBOMDHL_ == null)
					{
						this.PBMCHBOMDHL = new RogueMagicScepter();
					}
					input.ReadMessage(this.PBMCHBOMDHL);
				}
			}
		}

		// Token: 0x040028FE RID: 10494
		private static readonly MessageParser<JDGBFNHLADP> _parser = new MessageParser<JDGBFNHLADP>(() => new JDGBFNHLADP());

		// Token: 0x040028FF RID: 10495
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002900 RID: 10496
		public const int PBMCHBOMDHLFieldNumber = 13;

		// Token: 0x04002901 RID: 10497
		private RogueMagicScepter pBMCHBOMDHL_;
	}
}
