using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004D1 RID: 1233
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildUnlockInfoNotify : IMessage<EvolveBuildUnlockInfoNotify>, IMessage, IEquatable<EvolveBuildUnlockInfoNotify>, IDeepCloneable<EvolveBuildUnlockInfoNotify>, IBufferMessage
	{
		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x0600371F RID: 14111 RVA: 0x000975D9 File Offset: 0x000957D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildUnlockInfoNotify> Parser
		{
			get
			{
				return EvolveBuildUnlockInfoNotify._parser;
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06003720 RID: 14112 RVA: 0x000975E0 File Offset: 0x000957E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildUnlockInfoNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x000975F2 File Offset: 0x000957F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildUnlockInfoNotify.Descriptor;
			}
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x000975F9 File Offset: 0x000957F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildUnlockInfoNotify()
		{
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x00097601 File Offset: 0x00095801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildUnlockInfoNotify(EvolveBuildUnlockInfoNotify other) : this()
		{
			this.gMILJKPOPGD_ = other.gMILJKPOPGD_;
			this.gNJAGILEMCJ_ = other.gNJAGILEMCJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x00097632 File Offset: 0x00095832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildUnlockInfoNotify Clone()
		{
			return new EvolveBuildUnlockInfoNotify(this);
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06003725 RID: 14117 RVA: 0x0009763A File Offset: 0x0009583A
		// (set) Token: 0x06003726 RID: 14118 RVA: 0x00097642 File Offset: 0x00095842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GMILJKPOPGD
		{
			get
			{
				return this.gMILJKPOPGD_;
			}
			set
			{
				this.gMILJKPOPGD_ = value;
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06003727 RID: 14119 RVA: 0x0009764B File Offset: 0x0009584B
		// (set) Token: 0x06003728 RID: 14120 RVA: 0x00097653 File Offset: 0x00095853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GNJAGILEMCJ
		{
			get
			{
				return this.gNJAGILEMCJ_;
			}
			set
			{
				this.gNJAGILEMCJ_ = value;
			}
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x0009765C File Offset: 0x0009585C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildUnlockInfoNotify);
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x0009766A File Offset: 0x0009586A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildUnlockInfoNotify other)
		{
			return other != null && (other == this || (this.GMILJKPOPGD == other.GMILJKPOPGD && this.GNJAGILEMCJ == other.GNJAGILEMCJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x000976A8 File Offset: 0x000958A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GMILJKPOPGD)
			{
				num ^= this.GMILJKPOPGD.GetHashCode();
			}
			if (this.GNJAGILEMCJ)
			{
				num ^= this.GNJAGILEMCJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00097700 File Offset: 0x00095900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00097708 File Offset: 0x00095908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00097714 File Offset: 0x00095914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GNJAGILEMCJ)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.GNJAGILEMCJ);
			}
			if (this.GMILJKPOPGD)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.GMILJKPOPGD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x0009776C File Offset: 0x0009596C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GMILJKPOPGD)
			{
				num += 2;
			}
			if (this.GNJAGILEMCJ)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x000977AC File Offset: 0x000959AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildUnlockInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GMILJKPOPGD)
			{
				this.GMILJKPOPGD = other.GMILJKPOPGD;
			}
			if (other.GNJAGILEMCJ)
			{
				this.GNJAGILEMCJ = other.GNJAGILEMCJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x000977FC File Offset: 0x000959FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00097808 File Offset: 0x00095A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GMILJKPOPGD = input.ReadBool();
					}
				}
				else
				{
					this.GNJAGILEMCJ = input.ReadBool();
				}
			}
		}

		// Token: 0x040015DE RID: 5598
		private static readonly MessageParser<EvolveBuildUnlockInfoNotify> _parser = new MessageParser<EvolveBuildUnlockInfoNotify>(() => new EvolveBuildUnlockInfoNotify());

		// Token: 0x040015DF RID: 5599
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015E0 RID: 5600
		public const int GMILJKPOPGDFieldNumber = 10;

		// Token: 0x040015E1 RID: 5601
		private bool gMILJKPOPGD_;

		// Token: 0x040015E2 RID: 5602
		public const int GNJAGILEMCJFieldNumber = 1;

		// Token: 0x040015E3 RID: 5603
		private bool gNJAGILEMCJ_;
	}
}
