using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011B5 RID: 4533
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartMatchCsReq : IMessage<StartMatchCsReq>, IMessage, IEquatable<StartMatchCsReq>, IDeepCloneable<StartMatchCsReq>, IBufferMessage
	{
		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x0600CA71 RID: 51825 RVA: 0x0021F193 File Offset: 0x0021D393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartMatchCsReq> Parser
		{
			get
			{
				return StartMatchCsReq._parser;
			}
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x0600CA72 RID: 51826 RVA: 0x0021F19A File Offset: 0x0021D39A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartMatchCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x0600CA73 RID: 51827 RVA: 0x0021F1AC File Offset: 0x0021D3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartMatchCsReq.Descriptor;
			}
		}

		// Token: 0x0600CA74 RID: 51828 RVA: 0x0021F1B3 File Offset: 0x0021D3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchCsReq()
		{
		}

		// Token: 0x0600CA75 RID: 51829 RVA: 0x0021F1BC File Offset: 0x0021D3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchCsReq(StartMatchCsReq other) : this()
		{
			this.dIFNDEGMKNA_ = ((other.dIFNDEGMKNA_ != null) ? other.dIFNDEGMKNA_.Clone() : null);
			this.mGAIAJAKPEI_ = other.mGAIAJAKPEI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA76 RID: 51830 RVA: 0x0021F208 File Offset: 0x0021D408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchCsReq Clone()
		{
			return new StartMatchCsReq(this);
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x0600CA77 RID: 51831 RVA: 0x0021F210 File Offset: 0x0021D410
		// (set) Token: 0x0600CA78 RID: 51832 RVA: 0x0021F218 File Offset: 0x0021D418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGDACNIBFMP DIFNDEGMKNA
		{
			get
			{
				return this.dIFNDEGMKNA_;
			}
			set
			{
				this.dIFNDEGMKNA_ = value;
			}
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x0600CA79 RID: 51833 RVA: 0x0021F221 File Offset: 0x0021D421
		// (set) Token: 0x0600CA7A RID: 51834 RVA: 0x0021F229 File Offset: 0x0021D429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightGameMode MGAIAJAKPEI
		{
			get
			{
				return this.mGAIAJAKPEI_;
			}
			set
			{
				this.mGAIAJAKPEI_ = value;
			}
		}

		// Token: 0x0600CA7B RID: 51835 RVA: 0x0021F232 File Offset: 0x0021D432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartMatchCsReq);
		}

		// Token: 0x0600CA7C RID: 51836 RVA: 0x0021F240 File Offset: 0x0021D440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartMatchCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.DIFNDEGMKNA, other.DIFNDEGMKNA) && this.MGAIAJAKPEI == other.MGAIAJAKPEI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA7D RID: 51837 RVA: 0x0021F290 File Offset: 0x0021D490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dIFNDEGMKNA_ != null)
			{
				num ^= this.DIFNDEGMKNA.GetHashCode();
			}
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num ^= this.MGAIAJAKPEI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CA7E RID: 51838 RVA: 0x0021F2EB File Offset: 0x0021D4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CA7F RID: 51839 RVA: 0x0021F2F3 File Offset: 0x0021D4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA80 RID: 51840 RVA: 0x0021F2FC File Offset: 0x0021D4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dIFNDEGMKNA_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.DIFNDEGMKNA);
			}
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.MGAIAJAKPEI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CA81 RID: 51841 RVA: 0x0021F358 File Offset: 0x0021D558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dIFNDEGMKNA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DIFNDEGMKNA);
			}
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MGAIAJAKPEI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CA82 RID: 51842 RVA: 0x0021F3B0 File Offset: 0x0021D5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartMatchCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.dIFNDEGMKNA_ != null)
			{
				if (this.dIFNDEGMKNA_ == null)
				{
					this.DIFNDEGMKNA = new PGDACNIBFMP();
				}
				this.DIFNDEGMKNA.MergeFrom(other.DIFNDEGMKNA);
			}
			if (other.MGAIAJAKPEI != FightGameMode.None)
			{
				this.MGAIAJAKPEI = other.MGAIAJAKPEI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CA83 RID: 51843 RVA: 0x0021F418 File Offset: 0x0021D618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA84 RID: 51844 RVA: 0x0021F424 File Offset: 0x0021D624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MGAIAJAKPEI = (FightGameMode)input.ReadEnum();
					}
				}
				else
				{
					if (this.dIFNDEGMKNA_ == null)
					{
						this.DIFNDEGMKNA = new PGDACNIBFMP();
					}
					input.ReadMessage(this.DIFNDEGMKNA);
				}
			}
		}

		// Token: 0x040051A7 RID: 20903
		private static readonly MessageParser<StartMatchCsReq> _parser = new MessageParser<StartMatchCsReq>(() => new StartMatchCsReq());

		// Token: 0x040051A8 RID: 20904
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051A9 RID: 20905
		public const int DIFNDEGMKNAFieldNumber = 1;

		// Token: 0x040051AA RID: 20906
		private PGDACNIBFMP dIFNDEGMKNA_;

		// Token: 0x040051AB RID: 20907
		public const int MGAIAJAKPEIFieldNumber = 9;

		// Token: 0x040051AC RID: 20908
		private FightGameMode mGAIAJAKPEI_;
	}
}
