using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000807 RID: 2055
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetStageLineupScRsp : IMessage<GetStageLineupScRsp>, IMessage, IEquatable<GetStageLineupScRsp>, IDeepCloneable<GetStageLineupScRsp>, IBufferMessage
	{
		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06005BA3 RID: 23459 RVA: 0x000F3DFD File Offset: 0x000F1FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetStageLineupScRsp> Parser
		{
			get
			{
				return GetStageLineupScRsp._parser;
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x000F3E04 File Offset: 0x000F2004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetStageLineupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x06005BA5 RID: 23461 RVA: 0x000F3E16 File Offset: 0x000F2016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStageLineupScRsp.Descriptor;
			}
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x000F3E1D File Offset: 0x000F201D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStageLineupScRsp()
		{
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x000F3E30 File Offset: 0x000F2030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStageLineupScRsp(GetStageLineupScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.bOEOAFIKNEH_ = other.bOEOAFIKNEH_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x000F3E66 File Offset: 0x000F2066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStageLineupScRsp Clone()
		{
			return new GetStageLineupScRsp(this);
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x06005BA9 RID: 23465 RVA: 0x000F3E6E File Offset: 0x000F206E
		// (set) Token: 0x06005BAA RID: 23466 RVA: 0x000F3E76 File Offset: 0x000F2076
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

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06005BAB RID: 23467 RVA: 0x000F3E7F File Offset: 0x000F207F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AGLIOPELLCP> BOEOAFIKNEH
		{
			get
			{
				return this.bOEOAFIKNEH_;
			}
		}

		// Token: 0x06005BAC RID: 23468 RVA: 0x000F3E87 File Offset: 0x000F2087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStageLineupScRsp);
		}

		// Token: 0x06005BAD RID: 23469 RVA: 0x000F3E98 File Offset: 0x000F2098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetStageLineupScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.bOEOAFIKNEH_.Equals(other.bOEOAFIKNEH_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BAE RID: 23470 RVA: 0x000F3EE8 File Offset: 0x000F20E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.bOEOAFIKNEH_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x000F3F35 File Offset: 0x000F2135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005BB0 RID: 23472 RVA: 0x000F3F3D File Offset: 0x000F213D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BB1 RID: 23473 RVA: 0x000F3F48 File Offset: 0x000F2148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			this.bOEOAFIKNEH_.WriteTo(ref output, GetStageLineupScRsp._repeated_bOEOAFIKNEH_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BB2 RID: 23474 RVA: 0x000F3F98 File Offset: 0x000F2198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.bOEOAFIKNEH_.CalculateSize(GetStageLineupScRsp._repeated_bOEOAFIKNEH_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005BB3 RID: 23475 RVA: 0x000F3FEC File Offset: 0x000F21EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetStageLineupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.bOEOAFIKNEH_.Add(other.bOEOAFIKNEH_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005BB4 RID: 23476 RVA: 0x000F4039 File Offset: 0x000F2239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BB5 RID: 23477 RVA: 0x000F4044 File Offset: 0x000F2244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.bOEOAFIKNEH_.AddEntriesFrom(ref input, GetStageLineupScRsp._repeated_bOEOAFIKNEH_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002379 RID: 9081
		private static readonly MessageParser<GetStageLineupScRsp> _parser = new MessageParser<GetStageLineupScRsp>(() => new GetStageLineupScRsp());

		// Token: 0x0400237A RID: 9082
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400237B RID: 9083
		public const int RetcodeFieldNumber = 6;

		// Token: 0x0400237C RID: 9084
		private uint retcode_;

		// Token: 0x0400237D RID: 9085
		public const int BOEOAFIKNEHFieldNumber = 10;

		// Token: 0x0400237E RID: 9086
		private static readonly FieldCodec<AGLIOPELLCP> _repeated_bOEOAFIKNEH_codec = FieldCodec.ForMessage<AGLIOPELLCP>(82U, AGLIOPELLCP.Parser);

		// Token: 0x0400237F RID: 9087
		private readonly RepeatedField<AGLIOPELLCP> bOEOAFIKNEH_ = new RepeatedField<AGLIOPELLCP>();
	}
}
