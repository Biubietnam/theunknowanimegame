using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200080B RID: 2059
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetStarFightDataScRsp : IMessage<GetStarFightDataScRsp>, IMessage, IEquatable<GetStarFightDataScRsp>, IDeepCloneable<GetStarFightDataScRsp>, IBufferMessage
	{
		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06005BCC RID: 23500 RVA: 0x000F4305 File Offset: 0x000F2505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetStarFightDataScRsp> Parser
		{
			get
			{
				return GetStarFightDataScRsp._parser;
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06005BCD RID: 23501 RVA: 0x000F430C File Offset: 0x000F250C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetStarFightDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x06005BCE RID: 23502 RVA: 0x000F431E File Offset: 0x000F251E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStarFightDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x000F4325 File Offset: 0x000F2525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStarFightDataScRsp()
		{
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x000F4338 File Offset: 0x000F2538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStarFightDataScRsp(GetStarFightDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.jAFADPCHBPP_ = other.jAFADPCHBPP_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BD1 RID: 23505 RVA: 0x000F436E File Offset: 0x000F256E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStarFightDataScRsp Clone()
		{
			return new GetStarFightDataScRsp(this);
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06005BD2 RID: 23506 RVA: 0x000F4376 File Offset: 0x000F2576
		// (set) Token: 0x06005BD3 RID: 23507 RVA: 0x000F437E File Offset: 0x000F257E
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

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x06005BD4 RID: 23508 RVA: 0x000F4387 File Offset: 0x000F2587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HEFAKEFDMBL> JAFADPCHBPP
		{
			get
			{
				return this.jAFADPCHBPP_;
			}
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x000F438F File Offset: 0x000F258F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStarFightDataScRsp);
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x000F43A0 File Offset: 0x000F25A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetStarFightDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.jAFADPCHBPP_.Equals(other.jAFADPCHBPP_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x000F43F0 File Offset: 0x000F25F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.jAFADPCHBPP_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x000F443D File Offset: 0x000F263D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x000F4445 File Offset: 0x000F2645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x000F4450 File Offset: 0x000F2650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			this.jAFADPCHBPP_.WriteTo(ref output, GetStarFightDataScRsp._repeated_jAFADPCHBPP_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x000F44A0 File Offset: 0x000F26A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.jAFADPCHBPP_.CalculateSize(GetStarFightDataScRsp._repeated_jAFADPCHBPP_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x000F44F4 File Offset: 0x000F26F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetStarFightDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.jAFADPCHBPP_.Add(other.jAFADPCHBPP_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x000F4541 File Offset: 0x000F2741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x000F454C File Offset: 0x000F274C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.jAFADPCHBPP_.AddEntriesFrom(ref input, GetStarFightDataScRsp._repeated_jAFADPCHBPP_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002384 RID: 9092
		private static readonly MessageParser<GetStarFightDataScRsp> _parser = new MessageParser<GetStarFightDataScRsp>(() => new GetStarFightDataScRsp());

		// Token: 0x04002385 RID: 9093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002386 RID: 9094
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04002387 RID: 9095
		private uint retcode_;

		// Token: 0x04002388 RID: 9096
		public const int JAFADPCHBPPFieldNumber = 4;

		// Token: 0x04002389 RID: 9097
		private static readonly FieldCodec<HEFAKEFDMBL> _repeated_jAFADPCHBPP_codec = FieldCodec.ForMessage<HEFAKEFDMBL>(34U, HEFAKEFDMBL.Parser);

		// Token: 0x0400238A RID: 9098
		private readonly RepeatedField<HEFAKEFDMBL> jAFADPCHBPP_ = new RepeatedField<HEFAKEFDMBL>();
	}
}
