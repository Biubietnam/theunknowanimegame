using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013E5 RID: 5093
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateMovieRacingDataScRsp : IMessage<UpdateMovieRacingDataScRsp>, IMessage, IEquatable<UpdateMovieRacingDataScRsp>, IDeepCloneable<UpdateMovieRacingDataScRsp>, IBufferMessage
	{
		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x0600E311 RID: 58129 RVA: 0x0025C02D File Offset: 0x0025A22D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateMovieRacingDataScRsp> Parser
		{
			get
			{
				return UpdateMovieRacingDataScRsp._parser;
			}
		}

		// Token: 0x17003FC5 RID: 16325
		// (get) Token: 0x0600E312 RID: 58130 RVA: 0x0025C034 File Offset: 0x0025A234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateMovieRacingDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FC6 RID: 16326
		// (get) Token: 0x0600E313 RID: 58131 RVA: 0x0025C046 File Offset: 0x0025A246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMovieRacingDataScRsp.Descriptor;
			}
		}

		// Token: 0x0600E314 RID: 58132 RVA: 0x0025C04D File Offset: 0x0025A24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMovieRacingDataScRsp()
		{
		}

		// Token: 0x0600E315 RID: 58133 RVA: 0x0025C058 File Offset: 0x0025A258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMovieRacingDataScRsp(UpdateMovieRacingDataScRsp other) : this()
		{
			this.eJOFLNGKKIA_ = ((other.eJOFLNGKKIA_ != null) ? other.eJOFLNGKKIA_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E316 RID: 58134 RVA: 0x0025C0A4 File Offset: 0x0025A2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMovieRacingDataScRsp Clone()
		{
			return new UpdateMovieRacingDataScRsp(this);
		}

		// Token: 0x17003FC7 RID: 16327
		// (get) Token: 0x0600E317 RID: 58135 RVA: 0x0025C0AC File Offset: 0x0025A2AC
		// (set) Token: 0x0600E318 RID: 58136 RVA: 0x0025C0B4 File Offset: 0x0025A2B4
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

		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x0600E319 RID: 58137 RVA: 0x0025C0BD File Offset: 0x0025A2BD
		// (set) Token: 0x0600E31A RID: 58138 RVA: 0x0025C0C5 File Offset: 0x0025A2C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600E31B RID: 58139 RVA: 0x0025C0CE File Offset: 0x0025A2CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMovieRacingDataScRsp);
		}

		// Token: 0x0600E31C RID: 58140 RVA: 0x0025C0DC File Offset: 0x0025A2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateMovieRacingDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.EJOFLNGKKIA, other.EJOFLNGKKIA) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E31D RID: 58141 RVA: 0x0025C12C File Offset: 0x0025A32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.eJOFLNGKKIA_ != null)
			{
				num ^= this.EJOFLNGKKIA.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E31E RID: 58142 RVA: 0x0025C181 File Offset: 0x0025A381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E31F RID: 58143 RVA: 0x0025C189 File Offset: 0x0025A389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E320 RID: 58144 RVA: 0x0025C194 File Offset: 0x0025A394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.eJOFLNGKKIA_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.EJOFLNGKKIA);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E321 RID: 58145 RVA: 0x0025C1F0 File Offset: 0x0025A3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.eJOFLNGKKIA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EJOFLNGKKIA);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E322 RID: 58146 RVA: 0x0025C248 File Offset: 0x0025A448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateMovieRacingDataScRsp other)
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
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E323 RID: 58147 RVA: 0x0025C2B0 File Offset: 0x0025A4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E324 RID: 58148 RVA: 0x0025C2BC File Offset: 0x0025A4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
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

		// Token: 0x04005A4B RID: 23115
		private static readonly MessageParser<UpdateMovieRacingDataScRsp> _parser = new MessageParser<UpdateMovieRacingDataScRsp>(() => new UpdateMovieRacingDataScRsp());

		// Token: 0x04005A4C RID: 23116
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A4D RID: 23117
		public const int EJOFLNGKKIAFieldNumber = 5;

		// Token: 0x04005A4E RID: 23118
		private RacingData eJOFLNGKKIA_;

		// Token: 0x04005A4F RID: 23119
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04005A50 RID: 23120
		private uint retcode_;
	}
}
