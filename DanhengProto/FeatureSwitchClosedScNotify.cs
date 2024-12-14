using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200050D RID: 1293
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FeatureSwitchClosedScNotify : IMessage<FeatureSwitchClosedScNotify>, IMessage, IEquatable<FeatureSwitchClosedScNotify>, IDeepCloneable<FeatureSwitchClosedScNotify>, IBufferMessage
	{
		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060039F6 RID: 14838 RVA: 0x0009F845 File Offset: 0x0009DA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FeatureSwitchClosedScNotify> Parser
		{
			get
			{
				return FeatureSwitchClosedScNotify._parser;
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x0009F84C File Offset: 0x0009DA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FeatureSwitchClosedScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060039F8 RID: 14840 RVA: 0x0009F85E File Offset: 0x0009DA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeatureSwitchClosedScNotify.Descriptor;
			}
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x0009F865 File Offset: 0x0009DA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchClosedScNotify()
		{
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x0009F86D File Offset: 0x0009DA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchClosedScNotify(FeatureSwitchClosedScNotify other) : this()
		{
			this.ePFOBDAJPHN_ = other.ePFOBDAJPHN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x0009F892 File Offset: 0x0009DA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchClosedScNotify Clone()
		{
			return new FeatureSwitchClosedScNotify(this);
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x060039FC RID: 14844 RVA: 0x0009F89A File Offset: 0x0009DA9A
		// (set) Token: 0x060039FD RID: 14845 RVA: 0x0009F8A2 File Offset: 0x0009DAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchType EPFOBDAJPHN
		{
			get
			{
				return this.ePFOBDAJPHN_;
			}
			set
			{
				this.ePFOBDAJPHN_ = value;
			}
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x0009F8AB File Offset: 0x0009DAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeatureSwitchClosedScNotify);
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x0009F8B9 File Offset: 0x0009DAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeatureSwitchClosedScNotify other)
		{
			return other != null && (other == this || (this.EPFOBDAJPHN == other.EPFOBDAJPHN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x0009F8E8 File Offset: 0x0009DAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EPFOBDAJPHN != FeatureSwitchType.FeatureSwitchNone)
			{
				num ^= this.EPFOBDAJPHN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x0009F92D File Offset: 0x0009DB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x0009F935 File Offset: 0x0009DB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x0009F93E File Offset: 0x0009DB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EPFOBDAJPHN != FeatureSwitchType.FeatureSwitchNone)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.EPFOBDAJPHN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x0009F970 File Offset: 0x0009DB70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EPFOBDAJPHN != FeatureSwitchType.FeatureSwitchNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EPFOBDAJPHN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x0009F9AE File Offset: 0x0009DBAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeatureSwitchClosedScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EPFOBDAJPHN != FeatureSwitchType.FeatureSwitchNone)
			{
				this.EPFOBDAJPHN = other.EPFOBDAJPHN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x0009F9DF File Offset: 0x0009DBDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x0009F9E8 File Offset: 0x0009DBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EPFOBDAJPHN = (FeatureSwitchType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400171A RID: 5914
		private static readonly MessageParser<FeatureSwitchClosedScNotify> _parser = new MessageParser<FeatureSwitchClosedScNotify>(() => new FeatureSwitchClosedScNotify());

		// Token: 0x0400171B RID: 5915
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400171C RID: 5916
		public const int EPFOBDAJPHNFieldNumber = 14;

		// Token: 0x0400171D RID: 5917
		private FeatureSwitchType ePFOBDAJPHN_;
	}
}
