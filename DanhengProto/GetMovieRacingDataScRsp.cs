using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200073B RID: 1851
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMovieRacingDataScRsp : IMessage<GetMovieRacingDataScRsp>, IMessage, IEquatable<GetMovieRacingDataScRsp>, IDeepCloneable<GetMovieRacingDataScRsp>, IBufferMessage
	{
		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x060052BD RID: 21181 RVA: 0x000DEDB5 File Offset: 0x000DCFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMovieRacingDataScRsp> Parser
		{
			get
			{
				return GetMovieRacingDataScRsp._parser;
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x060052BE RID: 21182 RVA: 0x000DEDBC File Offset: 0x000DCFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMovieRacingDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x060052BF RID: 21183 RVA: 0x000DEDCE File Offset: 0x000DCFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMovieRacingDataScRsp.Descriptor;
			}
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x000DEDD5 File Offset: 0x000DCFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMovieRacingDataScRsp()
		{
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x000DEDE8 File Offset: 0x000DCFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMovieRacingDataScRsp(GetMovieRacingDataScRsp other) : this()
		{
			this.hAFEGLBEJEJ_ = other.hAFEGLBEJEJ_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x000DEE1E File Offset: 0x000DD01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMovieRacingDataScRsp Clone()
		{
			return new GetMovieRacingDataScRsp(this);
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x060052C3 RID: 21187 RVA: 0x000DEE26 File Offset: 0x000DD026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingData> HAFEGLBEJEJ
		{
			get
			{
				return this.hAFEGLBEJEJ_;
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x060052C4 RID: 21188 RVA: 0x000DEE2E File Offset: 0x000DD02E
		// (set) Token: 0x060052C5 RID: 21189 RVA: 0x000DEE36 File Offset: 0x000DD036
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

		// Token: 0x060052C6 RID: 21190 RVA: 0x000DEE3F File Offset: 0x000DD03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMovieRacingDataScRsp);
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x000DEE50 File Offset: 0x000DD050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMovieRacingDataScRsp other)
		{
			return other != null && (other == this || (this.hAFEGLBEJEJ_.Equals(other.hAFEGLBEJEJ_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x000DEEA0 File Offset: 0x000DD0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hAFEGLBEJEJ_.GetHashCode();
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

		// Token: 0x060052C9 RID: 21193 RVA: 0x000DEEED File Offset: 0x000DD0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x000DEEF5 File Offset: 0x000DD0F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x000DEF00 File Offset: 0x000DD100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hAFEGLBEJEJ_.WriteTo(ref output, GetMovieRacingDataScRsp._repeated_hAFEGLBEJEJ_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x000DEF50 File Offset: 0x000DD150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hAFEGLBEJEJ_.CalculateSize(GetMovieRacingDataScRsp._repeated_hAFEGLBEJEJ_codec);
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

		// Token: 0x060052CD RID: 21197 RVA: 0x000DEFA4 File Offset: 0x000DD1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMovieRacingDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.hAFEGLBEJEJ_.Add(other.hAFEGLBEJEJ_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x000DEFF1 File Offset: 0x000DD1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x000DEFFC File Offset: 0x000DD1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 112U)
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
					this.hAFEGLBEJEJ_.AddEntriesFrom(ref input, GetMovieRacingDataScRsp._repeated_hAFEGLBEJEJ_codec);
				}
			}
		}

		// Token: 0x04002083 RID: 8323
		private static readonly MessageParser<GetMovieRacingDataScRsp> _parser = new MessageParser<GetMovieRacingDataScRsp>(() => new GetMovieRacingDataScRsp());

		// Token: 0x04002084 RID: 8324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002085 RID: 8325
		public const int HAFEGLBEJEJFieldNumber = 9;

		// Token: 0x04002086 RID: 8326
		private static readonly FieldCodec<RacingData> _repeated_hAFEGLBEJEJ_codec = FieldCodec.ForMessage<RacingData>(74U, RacingData.Parser);

		// Token: 0x04002087 RID: 8327
		private readonly RepeatedField<RacingData> hAFEGLBEJEJ_ = new RepeatedField<RacingData>();

		// Token: 0x04002088 RID: 8328
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04002089 RID: 8329
		private uint retcode_;
	}
}
