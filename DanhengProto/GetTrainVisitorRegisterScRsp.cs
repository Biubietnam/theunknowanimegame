using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200082F RID: 2095
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTrainVisitorRegisterScRsp : IMessage<GetTrainVisitorRegisterScRsp>, IMessage, IEquatable<GetTrainVisitorRegisterScRsp>, IDeepCloneable<GetTrainVisitorRegisterScRsp>, IBufferMessage
	{
		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06005D3E RID: 23870 RVA: 0x000F7797 File Offset: 0x000F5997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTrainVisitorRegisterScRsp> Parser
		{
			get
			{
				return GetTrainVisitorRegisterScRsp._parser;
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06005D3F RID: 23871 RVA: 0x000F779E File Offset: 0x000F599E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTrainVisitorRegisterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06005D40 RID: 23872 RVA: 0x000F77B0 File Offset: 0x000F59B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTrainVisitorRegisterScRsp.Descriptor;
			}
		}

		// Token: 0x06005D41 RID: 23873 RVA: 0x000F77B7 File Offset: 0x000F59B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorRegisterScRsp()
		{
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x000F77D8 File Offset: 0x000F59D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorRegisterScRsp(GetTrainVisitorRegisterScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.bHJEIMILLPF_ = other.bHJEIMILLPF_.Clone();
			this.jBMPEGPPCHP_ = other.jBMPEGPPCHP_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D43 RID: 23875 RVA: 0x000F782A File Offset: 0x000F5A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrainVisitorRegisterScRsp Clone()
		{
			return new GetTrainVisitorRegisterScRsp(this);
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06005D44 RID: 23876 RVA: 0x000F7832 File Offset: 0x000F5A32
		// (set) Token: 0x06005D45 RID: 23877 RVA: 0x000F783A File Offset: 0x000F5A3A
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

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06005D46 RID: 23878 RVA: 0x000F7843 File Offset: 0x000F5A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BHJEIMILLPF
		{
			get
			{
				return this.bHJEIMILLPF_;
			}
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x06005D47 RID: 23879 RVA: 0x000F784B File Offset: 0x000F5A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrainVisitorInfo> JBMPEGPPCHP
		{
			get
			{
				return this.jBMPEGPPCHP_;
			}
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x000F7853 File Offset: 0x000F5A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTrainVisitorRegisterScRsp);
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x000F7864 File Offset: 0x000F5A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTrainVisitorRegisterScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.bHJEIMILLPF_.Equals(other.bHJEIMILLPF_) && this.jBMPEGPPCHP_.Equals(other.jBMPEGPPCHP_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x000F78C8 File Offset: 0x000F5AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.bHJEIMILLPF_.GetHashCode();
			num ^= this.jBMPEGPPCHP_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x000F7923 File Offset: 0x000F5B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x000F792B File Offset: 0x000F5B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x000F7934 File Offset: 0x000F5B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bHJEIMILLPF_.WriteTo(ref output, GetTrainVisitorRegisterScRsp._repeated_bHJEIMILLPF_codec);
			this.jBMPEGPPCHP_.WriteTo(ref output, GetTrainVisitorRegisterScRsp._repeated_jBMPEGPPCHP_codec);
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

		// Token: 0x06005D4E RID: 23886 RVA: 0x000F7994 File Offset: 0x000F5B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.bHJEIMILLPF_.CalculateSize(GetTrainVisitorRegisterScRsp._repeated_bHJEIMILLPF_codec);
			num += this.jBMPEGPPCHP_.CalculateSize(GetTrainVisitorRegisterScRsp._repeated_jBMPEGPPCHP_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D4F RID: 23887 RVA: 0x000F79F8 File Offset: 0x000F5BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTrainVisitorRegisterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.bHJEIMILLPF_.Add(other.bHJEIMILLPF_);
			this.jBMPEGPPCHP_.Add(other.jBMPEGPPCHP_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D50 RID: 23888 RVA: 0x000F7A56 File Offset: 0x000F5C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x000F7A60 File Offset: 0x000F5C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.bHJEIMILLPF_.AddEntriesFrom(ref input, GetTrainVisitorRegisterScRsp._repeated_bHJEIMILLPF_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.jBMPEGPPCHP_.AddEntriesFrom(ref input, GetTrainVisitorRegisterScRsp._repeated_jBMPEGPPCHP_codec);
						continue;
					}
					if (num == 112U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002403 RID: 9219
		private static readonly MessageParser<GetTrainVisitorRegisterScRsp> _parser = new MessageParser<GetTrainVisitorRegisterScRsp>(() => new GetTrainVisitorRegisterScRsp());

		// Token: 0x04002404 RID: 9220
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002405 RID: 9221
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04002406 RID: 9222
		private uint retcode_;

		// Token: 0x04002407 RID: 9223
		public const int BHJEIMILLPFFieldNumber = 1;

		// Token: 0x04002408 RID: 9224
		private static readonly FieldCodec<uint> _repeated_bHJEIMILLPF_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04002409 RID: 9225
		private readonly RepeatedField<uint> bHJEIMILLPF_ = new RepeatedField<uint>();

		// Token: 0x0400240A RID: 9226
		public const int JBMPEGPPCHPFieldNumber = 6;

		// Token: 0x0400240B RID: 9227
		private static readonly FieldCodec<TrainVisitorInfo> _repeated_jBMPEGPPCHP_codec = FieldCodec.ForMessage<TrainVisitorInfo>(50U, TrainVisitorInfo.Parser);

		// Token: 0x0400240C RID: 9228
		private readonly RepeatedField<TrainVisitorInfo> jBMPEGPPCHP_ = new RepeatedField<TrainVisitorInfo>();
	}
}
