using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A33 RID: 2611
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyCreateCsReq : IMessage<LobbyCreateCsReq>, IMessage, IEquatable<LobbyCreateCsReq>, IDeepCloneable<LobbyCreateCsReq>, IBufferMessage
	{
		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x060073D8 RID: 29656 RVA: 0x001341E7 File Offset: 0x001323E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyCreateCsReq> Parser
		{
			get
			{
				return LobbyCreateCsReq._parser;
			}
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x060073D9 RID: 29657 RVA: 0x001341EE File Offset: 0x001323EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyCreateCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x060073DA RID: 29658 RVA: 0x00134200 File Offset: 0x00132400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyCreateCsReq.Descriptor;
			}
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x00134207 File Offset: 0x00132407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyCreateCsReq()
		{
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x00134210 File Offset: 0x00132410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyCreateCsReq(LobbyCreateCsReq other) : this()
		{
			this.mGAIAJAKPEI_ = other.mGAIAJAKPEI_;
			this.dIFNDEGMKNA_ = ((other.dIFNDEGMKNA_ != null) ? other.dIFNDEGMKNA_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073DD RID: 29661 RVA: 0x0013425C File Offset: 0x0013245C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyCreateCsReq Clone()
		{
			return new LobbyCreateCsReq(this);
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x060073DE RID: 29662 RVA: 0x00134264 File Offset: 0x00132464
		// (set) Token: 0x060073DF RID: 29663 RVA: 0x0013426C File Offset: 0x0013246C
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

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x060073E0 RID: 29664 RVA: 0x00134275 File Offset: 0x00132475
		// (set) Token: 0x060073E1 RID: 29665 RVA: 0x0013427D File Offset: 0x0013247D
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

		// Token: 0x060073E2 RID: 29666 RVA: 0x00134286 File Offset: 0x00132486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyCreateCsReq);
		}

		// Token: 0x060073E3 RID: 29667 RVA: 0x00134294 File Offset: 0x00132494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyCreateCsReq other)
		{
			return other != null && (other == this || (this.MGAIAJAKPEI == other.MGAIAJAKPEI && object.Equals(this.DIFNDEGMKNA, other.DIFNDEGMKNA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073E4 RID: 29668 RVA: 0x001342E4 File Offset: 0x001324E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num ^= this.MGAIAJAKPEI.GetHashCode();
			}
			if (this.dIFNDEGMKNA_ != null)
			{
				num ^= this.DIFNDEGMKNA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060073E5 RID: 29669 RVA: 0x0013433F File Offset: 0x0013253F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060073E6 RID: 29670 RVA: 0x00134347 File Offset: 0x00132547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073E7 RID: 29671 RVA: 0x00134350 File Offset: 0x00132550
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
				output.WriteRawTag(104);
				output.WriteEnum((int)this.MGAIAJAKPEI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073E8 RID: 29672 RVA: 0x001343AC File Offset: 0x001325AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MGAIAJAKPEI);
			}
			if (this.dIFNDEGMKNA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DIFNDEGMKNA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060073E9 RID: 29673 RVA: 0x00134404 File Offset: 0x00132604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyCreateCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MGAIAJAKPEI != FightGameMode.None)
			{
				this.MGAIAJAKPEI = other.MGAIAJAKPEI;
			}
			if (other.dIFNDEGMKNA_ != null)
			{
				if (this.dIFNDEGMKNA_ == null)
				{
					this.DIFNDEGMKNA = new PGDACNIBFMP();
				}
				this.DIFNDEGMKNA.MergeFrom(other.DIFNDEGMKNA);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073EA RID: 29674 RVA: 0x0013446C File Offset: 0x0013266C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073EB RID: 29675 RVA: 0x00134478 File Offset: 0x00132678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 104U)
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

		// Token: 0x04002C94 RID: 11412
		private static readonly MessageParser<LobbyCreateCsReq> _parser = new MessageParser<LobbyCreateCsReq>(() => new LobbyCreateCsReq());

		// Token: 0x04002C95 RID: 11413
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C96 RID: 11414
		public const int MGAIAJAKPEIFieldNumber = 13;

		// Token: 0x04002C97 RID: 11415
		private FightGameMode mGAIAJAKPEI_;

		// Token: 0x04002C98 RID: 11416
		public const int DIFNDEGMKNAFieldNumber = 1;

		// Token: 0x04002C99 RID: 11417
		private PGDACNIBFMP dIFNDEGMKNA_;
	}
}
