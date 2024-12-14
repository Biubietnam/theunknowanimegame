using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006F7 RID: 1783
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetLevelRewardTakenListScRsp : IMessage<GetLevelRewardTakenListScRsp>, IMessage, IEquatable<GetLevelRewardTakenListScRsp>, IDeepCloneable<GetLevelRewardTakenListScRsp>, IBufferMessage
	{
		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x000D7385 File Offset: 0x000D5585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetLevelRewardTakenListScRsp> Parser
		{
			get
			{
				return GetLevelRewardTakenListScRsp._parser;
			}
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06004FBA RID: 20410 RVA: 0x000D738C File Offset: 0x000D558C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetLevelRewardTakenListScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06004FBB RID: 20411 RVA: 0x000D739E File Offset: 0x000D559E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLevelRewardTakenListScRsp.Descriptor;
			}
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x000D73A5 File Offset: 0x000D55A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardTakenListScRsp()
		{
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x000D73B8 File Offset: 0x000D55B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardTakenListScRsp(GetLevelRewardTakenListScRsp other) : this()
		{
			this.levelRewardTakenList_ = other.levelRewardTakenList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x000D73EE File Offset: 0x000D55EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardTakenListScRsp Clone()
		{
			return new GetLevelRewardTakenListScRsp(this);
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06004FBF RID: 20415 RVA: 0x000D73F6 File Offset: 0x000D55F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LevelRewardTakenList
		{
			get
			{
				return this.levelRewardTakenList_;
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06004FC0 RID: 20416 RVA: 0x000D73FE File Offset: 0x000D55FE
		// (set) Token: 0x06004FC1 RID: 20417 RVA: 0x000D7406 File Offset: 0x000D5606
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

		// Token: 0x06004FC2 RID: 20418 RVA: 0x000D740F File Offset: 0x000D560F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLevelRewardTakenListScRsp);
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x000D7420 File Offset: 0x000D5620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLevelRewardTakenListScRsp other)
		{
			return other != null && (other == this || (this.levelRewardTakenList_.Equals(other.levelRewardTakenList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x000D7470 File Offset: 0x000D5670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.levelRewardTakenList_.GetHashCode();
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

		// Token: 0x06004FC5 RID: 20421 RVA: 0x000D74BD File Offset: 0x000D56BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004FC6 RID: 20422 RVA: 0x000D74C5 File Offset: 0x000D56C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x000D74D0 File Offset: 0x000D56D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			this.levelRewardTakenList_.WriteTo(ref output, GetLevelRewardTakenListScRsp._repeated_levelRewardTakenList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x000D7520 File Offset: 0x000D5720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.levelRewardTakenList_.CalculateSize(GetLevelRewardTakenListScRsp._repeated_levelRewardTakenList_codec);
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

		// Token: 0x06004FC9 RID: 20425 RVA: 0x000D7574 File Offset: 0x000D5774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLevelRewardTakenListScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.levelRewardTakenList_.Add(other.levelRewardTakenList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x000D75C1 File Offset: 0x000D57C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x000D75CC File Offset: 0x000D57CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.levelRewardTakenList_.AddEntriesFrom(ref input, GetLevelRewardTakenListScRsp._repeated_levelRewardTakenList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F67 RID: 8039
		private static readonly MessageParser<GetLevelRewardTakenListScRsp> _parser = new MessageParser<GetLevelRewardTakenListScRsp>(() => new GetLevelRewardTakenListScRsp());

		// Token: 0x04001F68 RID: 8040
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F69 RID: 8041
		public const int LevelRewardTakenListFieldNumber = 15;

		// Token: 0x04001F6A RID: 8042
		private static readonly FieldCodec<uint> _repeated_levelRewardTakenList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04001F6B RID: 8043
		private readonly RepeatedField<uint> levelRewardTakenList_ = new RepeatedField<uint>();

		// Token: 0x04001F6C RID: 8044
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04001F6D RID: 8045
		private uint retcode_;
	}
}
