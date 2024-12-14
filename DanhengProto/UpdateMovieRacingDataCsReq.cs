using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013E3 RID: 5091
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateMovieRacingDataCsReq : IMessage<UpdateMovieRacingDataCsReq>, IMessage, IEquatable<UpdateMovieRacingDataCsReq>, IDeepCloneable<UpdateMovieRacingDataCsReq>, IBufferMessage
	{
		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x0600E2FC RID: 58108 RVA: 0x0025BD61 File Offset: 0x00259F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateMovieRacingDataCsReq> Parser
		{
			get
			{
				return UpdateMovieRacingDataCsReq._parser;
			}
		}

		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x0600E2FD RID: 58109 RVA: 0x0025BD68 File Offset: 0x00259F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateMovieRacingDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FC1 RID: 16321
		// (get) Token: 0x0600E2FE RID: 58110 RVA: 0x0025BD7A File Offset: 0x00259F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMovieRacingDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600E2FF RID: 58111 RVA: 0x0025BD81 File Offset: 0x00259F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMovieRacingDataCsReq()
		{
		}

		// Token: 0x0600E300 RID: 58112 RVA: 0x0025BD89 File Offset: 0x00259F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMovieRacingDataCsReq(UpdateMovieRacingDataCsReq other) : this()
		{
			this.eJOFLNGKKIA_ = ((other.eJOFLNGKKIA_ != null) ? other.eJOFLNGKKIA_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E301 RID: 58113 RVA: 0x0025BDBE File Offset: 0x00259FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMovieRacingDataCsReq Clone()
		{
			return new UpdateMovieRacingDataCsReq(this);
		}

		// Token: 0x17003FC2 RID: 16322
		// (get) Token: 0x0600E302 RID: 58114 RVA: 0x0025BDC6 File Offset: 0x00259FC6
		// (set) Token: 0x0600E303 RID: 58115 RVA: 0x0025BDCE File Offset: 0x00259FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingData EJOFLNGKKIA
		{
			get
			{
				return this.eJOFLNGKKIA_;
			}
			set
			{
				this.eJOFLNGKKIA_ = value;
			}
		}

		// Token: 0x0600E304 RID: 58116 RVA: 0x0025BDD7 File Offset: 0x00259FD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMovieRacingDataCsReq);
		}

		// Token: 0x0600E305 RID: 58117 RVA: 0x0025BDE5 File Offset: 0x00259FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateMovieRacingDataCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.EJOFLNGKKIA, other.EJOFLNGKKIA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E306 RID: 58118 RVA: 0x0025BE18 File Offset: 0x0025A018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.eJOFLNGKKIA_ != null)
			{
				num ^= this.EJOFLNGKKIA.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E307 RID: 58119 RVA: 0x0025BE54 File Offset: 0x0025A054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E308 RID: 58120 RVA: 0x0025BE5C File Offset: 0x0025A05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E309 RID: 58121 RVA: 0x0025BE65 File Offset: 0x0025A065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.eJOFLNGKKIA_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.EJOFLNGKKIA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E30A RID: 58122 RVA: 0x0025BE98 File Offset: 0x0025A098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.eJOFLNGKKIA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EJOFLNGKKIA);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E30B RID: 58123 RVA: 0x0025BED8 File Offset: 0x0025A0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateMovieRacingDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.eJOFLNGKKIA_ != null)
			{
				if (this.eJOFLNGKKIA_ == null)
				{
					this.EJOFLNGKKIA = new RacingData();
				}
				this.EJOFLNGKKIA.MergeFrom(other.EJOFLNGKKIA);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E30C RID: 58124 RVA: 0x0025BF2C File Offset: 0x0025A12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E30D RID: 58125 RVA: 0x0025BF38 File Offset: 0x0025A138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.eJOFLNGKKIA_ == null)
					{
						this.EJOFLNGKKIA = new RacingData();
					}
					input.ReadMessage(this.EJOFLNGKKIA);
				}
			}
		}

		// Token: 0x04005A46 RID: 23110
		private static readonly MessageParser<UpdateMovieRacingDataCsReq> _parser = new MessageParser<UpdateMovieRacingDataCsReq>(() => new UpdateMovieRacingDataCsReq());

		// Token: 0x04005A47 RID: 23111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A48 RID: 23112
		public const int EJOFLNGKKIAFieldNumber = 12;

		// Token: 0x04005A49 RID: 23113
		private RacingData eJOFLNGKKIA_;
	}
}
