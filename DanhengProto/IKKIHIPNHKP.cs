using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000929 RID: 2345
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IKKIHIPNHKP : IMessage<IKKIHIPNHKP>, IMessage, IEquatable<IKKIHIPNHKP>, IDeepCloneable<IKKIHIPNHKP>, IBufferMessage
	{
		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x0600689F RID: 26783 RVA: 0x00117780 File Offset: 0x00115980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IKKIHIPNHKP> Parser
		{
			get
			{
				return IKKIHIPNHKP._parser;
			}
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x060068A0 RID: 26784 RVA: 0x00117787 File Offset: 0x00115987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IKKIHIPNHKPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x060068A1 RID: 26785 RVA: 0x00117799 File Offset: 0x00115999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IKKIHIPNHKP.Descriptor;
			}
		}

		// Token: 0x060068A2 RID: 26786 RVA: 0x001177A0 File Offset: 0x001159A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IKKIHIPNHKP()
		{
		}

		// Token: 0x060068A3 RID: 26787 RVA: 0x001177A8 File Offset: 0x001159A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IKKIHIPNHKP(IKKIHIPNHKP other) : this()
		{
			this.z_ = other.z_;
			this.y_ = other.y_;
			this.lLHKKEFLPIP_ = other.lLHKKEFLPIP_;
			this.x_ = other.x_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x001177FC File Offset: 0x001159FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IKKIHIPNHKP Clone()
		{
			return new IKKIHIPNHKP(this);
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x060068A5 RID: 26789 RVA: 0x00117804 File Offset: 0x00115A04
		// (set) Token: 0x060068A6 RID: 26790 RVA: 0x0011780C File Offset: 0x00115A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Z
		{
			get
			{
				return this.z_;
			}
			set
			{
				this.z_ = value;
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x060068A7 RID: 26791 RVA: 0x00117815 File Offset: 0x00115A15
		// (set) Token: 0x060068A8 RID: 26792 RVA: 0x0011781D File Offset: 0x00115A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x060068A9 RID: 26793 RVA: 0x00117826 File Offset: 0x00115A26
		// (set) Token: 0x060068AA RID: 26794 RVA: 0x0011782E File Offset: 0x00115A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float LLHKKEFLPIP
		{
			get
			{
				return this.lLHKKEFLPIP_;
			}
			set
			{
				this.lLHKKEFLPIP_ = value;
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x060068AB RID: 26795 RVA: 0x00117837 File Offset: 0x00115A37
		// (set) Token: 0x060068AC RID: 26796 RVA: 0x0011783F File Offset: 0x00115A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x00117848 File Offset: 0x00115A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IKKIHIPNHKP);
		}

		// Token: 0x060068AE RID: 26798 RVA: 0x00117858 File Offset: 0x00115A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IKKIHIPNHKP other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Z, other.Z) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Y, other.Y) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.LLHKKEFLPIP, other.LLHKKEFLPIP) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.X, other.X) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x001178EC File Offset: 0x00115AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Z != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Z);
			}
			if (this.Y != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Y);
			}
			if (this.LLHKKEFLPIP != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.LLHKKEFLPIP);
			}
			if (this.X != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.X);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x00117992 File Offset: 0x00115B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x0011799A File Offset: 0x00115B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x001179A4 File Offset: 0x00115BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Z != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.Z);
			}
			if (this.LLHKKEFLPIP != 0f)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.LLHKKEFLPIP);
			}
			if (this.X != 0f)
			{
				output.WriteRawTag(93);
				output.WriteFloat(this.X);
			}
			if (this.Y != 0f)
			{
				output.WriteRawTag(101);
				output.WriteFloat(this.Y);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x00117A4C File Offset: 0x00115C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Z != 0f)
			{
				num += 5;
			}
			if (this.Y != 0f)
			{
				num += 5;
			}
			if (this.LLHKKEFLPIP != 0f)
			{
				num += 5;
			}
			if (this.X != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x00117AB8 File Offset: 0x00115CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IKKIHIPNHKP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Z != 0f)
			{
				this.Z = other.Z;
			}
			if (other.Y != 0f)
			{
				this.Y = other.Y;
			}
			if (other.LLHKKEFLPIP != 0f)
			{
				this.LLHKKEFLPIP = other.LLHKKEFLPIP;
			}
			if (other.X != 0f)
			{
				this.X = other.X;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x00117B44 File Offset: 0x00115D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x00117B50 File Offset: 0x00115D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 77U)
				{
					if (num == 61U)
					{
						this.Z = input.ReadFloat();
						continue;
					}
					if (num == 77U)
					{
						this.LLHKKEFLPIP = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 93U)
					{
						this.X = input.ReadFloat();
						continue;
					}
					if (num == 101U)
					{
						this.Y = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002823 RID: 10275
		private static readonly MessageParser<IKKIHIPNHKP> _parser = new MessageParser<IKKIHIPNHKP>(() => new IKKIHIPNHKP());

		// Token: 0x04002824 RID: 10276
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002825 RID: 10277
		public const int ZFieldNumber = 7;

		// Token: 0x04002826 RID: 10278
		private float z_;

		// Token: 0x04002827 RID: 10279
		public const int YFieldNumber = 12;

		// Token: 0x04002828 RID: 10280
		private float y_;

		// Token: 0x04002829 RID: 10281
		public const int LLHKKEFLPIPFieldNumber = 9;

		// Token: 0x0400282A RID: 10282
		private float lLHKKEFLPIP_;

		// Token: 0x0400282B RID: 10283
		public const int XFieldNumber = 11;

		// Token: 0x0400282C RID: 10284
		private float x_;
	}
}
