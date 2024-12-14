using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D65 RID: 3429
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RaidCollectionDataScRsp : IMessage<RaidCollectionDataScRsp>, IMessage, IEquatable<RaidCollectionDataScRsp>, IDeepCloneable<RaidCollectionDataScRsp>, IBufferMessage
	{
		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x06009933 RID: 39219 RVA: 0x00197C75 File Offset: 0x00195E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RaidCollectionDataScRsp> Parser
		{
			get
			{
				return RaidCollectionDataScRsp._parser;
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x06009934 RID: 39220 RVA: 0x00197C7C File Offset: 0x00195E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RaidCollectionDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x06009935 RID: 39221 RVA: 0x00197C8E File Offset: 0x00195E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RaidCollectionDataScRsp.Descriptor;
			}
		}

		// Token: 0x06009936 RID: 39222 RVA: 0x00197C95 File Offset: 0x00195E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionDataScRsp()
		{
		}

		// Token: 0x06009937 RID: 39223 RVA: 0x00197CA8 File Offset: 0x00195EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionDataScRsp(RaidCollectionDataScRsp other) : this()
		{
			this.challengeList_ = other.challengeList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009938 RID: 39224 RVA: 0x00197CDE File Offset: 0x00195EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionDataScRsp Clone()
		{
			return new RaidCollectionDataScRsp(this);
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x06009939 RID: 39225 RVA: 0x00197CE6 File Offset: 0x00195EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KOGBDHNMMDF> ChallengeList
		{
			get
			{
				return this.challengeList_;
			}
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x0600993A RID: 39226 RVA: 0x00197CEE File Offset: 0x00195EEE
		// (set) Token: 0x0600993B RID: 39227 RVA: 0x00197CF6 File Offset: 0x00195EF6
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

		// Token: 0x0600993C RID: 39228 RVA: 0x00197CFF File Offset: 0x00195EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RaidCollectionDataScRsp);
		}

		// Token: 0x0600993D RID: 39229 RVA: 0x00197D10 File Offset: 0x00195F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RaidCollectionDataScRsp other)
		{
			return other != null && (other == this || (this.challengeList_.Equals(other.challengeList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600993E RID: 39230 RVA: 0x00197D60 File Offset: 0x00195F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challengeList_.GetHashCode();
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

		// Token: 0x0600993F RID: 39231 RVA: 0x00197DAD File Offset: 0x00195FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009940 RID: 39232 RVA: 0x00197DB5 File Offset: 0x00195FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009941 RID: 39233 RVA: 0x00197DC0 File Offset: 0x00195FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeList_.WriteTo(ref output, RaidCollectionDataScRsp._repeated_challengeList_codec);
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

		// Token: 0x06009942 RID: 39234 RVA: 0x00197E10 File Offset: 0x00196010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challengeList_.CalculateSize(RaidCollectionDataScRsp._repeated_challengeList_codec);
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

		// Token: 0x06009943 RID: 39235 RVA: 0x00197E64 File Offset: 0x00196064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RaidCollectionDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.challengeList_.Add(other.challengeList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009944 RID: 39236 RVA: 0x00197EB1 File Offset: 0x001960B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009945 RID: 39237 RVA: 0x00197EBC File Offset: 0x001960BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
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
					this.challengeList_.AddEntriesFrom(ref input, RaidCollectionDataScRsp._repeated_challengeList_codec);
				}
			}
		}

		// Token: 0x04003B78 RID: 15224
		private static readonly MessageParser<RaidCollectionDataScRsp> _parser = new MessageParser<RaidCollectionDataScRsp>(() => new RaidCollectionDataScRsp());

		// Token: 0x04003B79 RID: 15225
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B7A RID: 15226
		public const int ChallengeListFieldNumber = 13;

		// Token: 0x04003B7B RID: 15227
		private static readonly FieldCodec<KOGBDHNMMDF> _repeated_challengeList_codec = FieldCodec.ForMessage<KOGBDHNMMDF>(106U, KOGBDHNMMDF.Parser);

		// Token: 0x04003B7C RID: 15228
		private readonly RepeatedField<KOGBDHNMMDF> challengeList_ = new RepeatedField<KOGBDHNMMDF>();

		// Token: 0x04003B7D RID: 15229
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04003B7E RID: 15230
		private uint retcode_;
	}
}
