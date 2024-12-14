using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008F7 RID: 2295
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HKMBKGENKBG : IMessage<HKMBKGENKBG>, IMessage, IEquatable<HKMBKGENKBG>, IDeepCloneable<HKMBKGENKBG>, IBufferMessage
	{
		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06006660 RID: 26208 RVA: 0x00111979 File Offset: 0x0010FB79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HKMBKGENKBG> Parser
		{
			get
			{
				return HKMBKGENKBG._parser;
			}
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06006661 RID: 26209 RVA: 0x00111980 File Offset: 0x0010FB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HKMBKGENKBGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x06006662 RID: 26210 RVA: 0x00111992 File Offset: 0x0010FB92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HKMBKGENKBG.Descriptor;
			}
		}

		// Token: 0x06006663 RID: 26211 RVA: 0x00111999 File Offset: 0x0010FB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HKMBKGENKBG()
		{
		}

		// Token: 0x06006664 RID: 26212 RVA: 0x001119A1 File Offset: 0x0010FBA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HKMBKGENKBG(HKMBKGENKBG other) : this()
		{
			this.status_ = other.status_;
			this.oLMOHJOAKGF_ = other.oLMOHJOAKGF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006665 RID: 26213 RVA: 0x001119D2 File Offset: 0x0010FBD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HKMBKGENKBG Clone()
		{
			return new HKMBKGENKBG(this);
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06006666 RID: 26214 RVA: 0x001119DA File Offset: 0x0010FBDA
		// (set) Token: 0x06006667 RID: 26215 RVA: 0x001119E2 File Offset: 0x0010FBE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCollectionStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06006668 RID: 26216 RVA: 0x001119EB File Offset: 0x0010FBEB
		// (set) Token: 0x06006669 RID: 26217 RVA: 0x001119F3 File Offset: 0x0010FBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OLMOHJOAKGF
		{
			get
			{
				return this.oLMOHJOAKGF_;
			}
			set
			{
				this.oLMOHJOAKGF_ = value;
			}
		}

		// Token: 0x0600666A RID: 26218 RVA: 0x001119FC File Offset: 0x0010FBFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HKMBKGENKBG);
		}

		// Token: 0x0600666B RID: 26219 RVA: 0x00111A0A File Offset: 0x0010FC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HKMBKGENKBG other)
		{
			return other != null && (other == this || (this.Status == other.Status && this.OLMOHJOAKGF == other.OLMOHJOAKGF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600666C RID: 26220 RVA: 0x00111A48 File Offset: 0x0010FC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Status != RogueCollectionStatus.RogueCollectionNone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.OLMOHJOAKGF != 0U)
			{
				num ^= this.OLMOHJOAKGF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600666D RID: 26221 RVA: 0x00111AA6 File Offset: 0x0010FCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600666E RID: 26222 RVA: 0x00111AAE File Offset: 0x0010FCAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600666F RID: 26223 RVA: 0x00111AB8 File Offset: 0x0010FCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Status != RogueCollectionStatus.RogueCollectionNone)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Status);
			}
			if (this.OLMOHJOAKGF != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.OLMOHJOAKGF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006670 RID: 26224 RVA: 0x00111B14 File Offset: 0x0010FD14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Status != RogueCollectionStatus.RogueCollectionNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.OLMOHJOAKGF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OLMOHJOAKGF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006671 RID: 26225 RVA: 0x00111B6C File Offset: 0x0010FD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HKMBKGENKBG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Status != RogueCollectionStatus.RogueCollectionNone)
			{
				this.Status = other.Status;
			}
			if (other.OLMOHJOAKGF != 0U)
			{
				this.OLMOHJOAKGF = other.OLMOHJOAKGF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006672 RID: 26226 RVA: 0x00111BBC File Offset: 0x0010FDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006673 RID: 26227 RVA: 0x00111BC8 File Offset: 0x0010FDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OLMOHJOAKGF = input.ReadUInt32();
					}
				}
				else
				{
					this.Status = (RogueCollectionStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400275B RID: 10075
		private static readonly MessageParser<HKMBKGENKBG> _parser = new MessageParser<HKMBKGENKBG>(() => new HKMBKGENKBG());

		// Token: 0x0400275C RID: 10076
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400275D RID: 10077
		public const int StatusFieldNumber = 5;

		// Token: 0x0400275E RID: 10078
		private RogueCollectionStatus status_;

		// Token: 0x0400275F RID: 10079
		public const int OLMOHJOAKGFFieldNumber = 8;

		// Token: 0x04002760 RID: 10080
		private uint oLMOHJOAKGF_;
	}
}
