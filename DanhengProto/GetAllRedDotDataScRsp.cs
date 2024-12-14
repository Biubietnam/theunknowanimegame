using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200060D RID: 1549
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAllRedDotDataScRsp : IMessage<GetAllRedDotDataScRsp>, IMessage, IEquatable<GetAllRedDotDataScRsp>, IDeepCloneable<GetAllRedDotDataScRsp>, IBufferMessage
	{
		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x0600457E RID: 17790 RVA: 0x000BEA99 File Offset: 0x000BCC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAllRedDotDataScRsp> Parser
		{
			get
			{
				return GetAllRedDotDataScRsp._parser;
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x000BEAA0 File Offset: 0x000BCCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAllRedDotDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x000BEAB2 File Offset: 0x000BCCB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllRedDotDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x000BEAB9 File Offset: 0x000BCCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllRedDotDataScRsp()
		{
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x000BEACC File Offset: 0x000BCCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllRedDotDataScRsp(GetAllRedDotDataScRsp other) : this()
		{
			this.jLMALJKDLLC_ = other.jLMALJKDLLC_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x000BEB02 File Offset: 0x000BCD02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllRedDotDataScRsp Clone()
		{
			return new GetAllRedDotDataScRsp(this);
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x000BEB0A File Offset: 0x000BCD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BJLCIEAOMLP> JLMALJKDLLC
		{
			get
			{
				return this.jLMALJKDLLC_;
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x06004585 RID: 17797 RVA: 0x000BEB12 File Offset: 0x000BCD12
		// (set) Token: 0x06004586 RID: 17798 RVA: 0x000BEB1A File Offset: 0x000BCD1A
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

		// Token: 0x06004587 RID: 17799 RVA: 0x000BEB23 File Offset: 0x000BCD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllRedDotDataScRsp);
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x000BEB34 File Offset: 0x000BCD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAllRedDotDataScRsp other)
		{
			return other != null && (other == this || (this.jLMALJKDLLC_.Equals(other.jLMALJKDLLC_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x000BEB84 File Offset: 0x000BCD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.jLMALJKDLLC_.GetHashCode();
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

		// Token: 0x0600458A RID: 17802 RVA: 0x000BEBD1 File Offset: 0x000BCDD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x000BEBD9 File Offset: 0x000BCDD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x000BEBE4 File Offset: 0x000BCDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			this.jLMALJKDLLC_.WriteTo(ref output, GetAllRedDotDataScRsp._repeated_jLMALJKDLLC_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x000BEC34 File Offset: 0x000BCE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.jLMALJKDLLC_.CalculateSize(GetAllRedDotDataScRsp._repeated_jLMALJKDLLC_codec);
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

		// Token: 0x0600458E RID: 17806 RVA: 0x000BEC88 File Offset: 0x000BCE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAllRedDotDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.jLMALJKDLLC_.Add(other.jLMALJKDLLC_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x000BECD5 File Offset: 0x000BCED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x000BECE0 File Offset: 0x000BCEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.jLMALJKDLLC_.AddEntriesFrom(ref input, GetAllRedDotDataScRsp._repeated_jLMALJKDLLC_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001BD7 RID: 7127
		private static readonly MessageParser<GetAllRedDotDataScRsp> _parser = new MessageParser<GetAllRedDotDataScRsp>(() => new GetAllRedDotDataScRsp());

		// Token: 0x04001BD8 RID: 7128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BD9 RID: 7129
		public const int JLMALJKDLLCFieldNumber = 8;

		// Token: 0x04001BDA RID: 7130
		private static readonly FieldCodec<BJLCIEAOMLP> _repeated_jLMALJKDLLC_codec = FieldCodec.ForMessage<BJLCIEAOMLP>(66U, BJLCIEAOMLP.Parser);

		// Token: 0x04001BDB RID: 7131
		private readonly RepeatedField<BJLCIEAOMLP> jLMALJKDLLC_ = new RepeatedField<BJLCIEAOMLP>();

		// Token: 0x04001BDC RID: 7132
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04001BDD RID: 7133
		private uint retcode_;
	}
}
