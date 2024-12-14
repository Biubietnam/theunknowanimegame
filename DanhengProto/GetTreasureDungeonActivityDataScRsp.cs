using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000833 RID: 2099
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTreasureDungeonActivityDataScRsp : IMessage<GetTreasureDungeonActivityDataScRsp>, IMessage, IEquatable<GetTreasureDungeonActivityDataScRsp>, IDeepCloneable<GetTreasureDungeonActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06005D68 RID: 23912 RVA: 0x000F7D6B File Offset: 0x000F5F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTreasureDungeonActivityDataScRsp> Parser
		{
			get
			{
				return GetTreasureDungeonActivityDataScRsp._parser;
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06005D69 RID: 23913 RVA: 0x000F7D72 File Offset: 0x000F5F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTreasureDungeonActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06005D6A RID: 23914 RVA: 0x000F7D84 File Offset: 0x000F5F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTreasureDungeonActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x000F7D8B File Offset: 0x000F5F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTreasureDungeonActivityDataScRsp()
		{
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x000F7D9E File Offset: 0x000F5F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTreasureDungeonActivityDataScRsp(GetTreasureDungeonActivityDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.jFPIPIBOIFC_ = other.jFPIPIBOIFC_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x000F7DD4 File Offset: 0x000F5FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTreasureDungeonActivityDataScRsp Clone()
		{
			return new GetTreasureDungeonActivityDataScRsp(this);
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06005D6E RID: 23918 RVA: 0x000F7DDC File Offset: 0x000F5FDC
		// (set) Token: 0x06005D6F RID: 23919 RVA: 0x000F7DE4 File Offset: 0x000F5FE4
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

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06005D70 RID: 23920 RVA: 0x000F7DED File Offset: 0x000F5FED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreasureDungeonActivityData> JFPIPIBOIFC
		{
			get
			{
				return this.jFPIPIBOIFC_;
			}
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x000F7DF5 File Offset: 0x000F5FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTreasureDungeonActivityDataScRsp);
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x000F7E04 File Offset: 0x000F6004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTreasureDungeonActivityDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.jFPIPIBOIFC_.Equals(other.jFPIPIBOIFC_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x000F7E54 File Offset: 0x000F6054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.jFPIPIBOIFC_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x000F7EA1 File Offset: 0x000F60A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x000F7EA9 File Offset: 0x000F60A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D76 RID: 23926 RVA: 0x000F7EB4 File Offset: 0x000F60B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jFPIPIBOIFC_.WriteTo(ref output, GetTreasureDungeonActivityDataScRsp._repeated_jFPIPIBOIFC_codec);
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

		// Token: 0x06005D77 RID: 23927 RVA: 0x000F7F04 File Offset: 0x000F6104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.jFPIPIBOIFC_.CalculateSize(GetTreasureDungeonActivityDataScRsp._repeated_jFPIPIBOIFC_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x000F7F58 File Offset: 0x000F6158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTreasureDungeonActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.jFPIPIBOIFC_.Add(other.jFPIPIBOIFC_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x000F7FA5 File Offset: 0x000F61A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x000F7FB0 File Offset: 0x000F61B0
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
					this.jFPIPIBOIFC_.AddEntriesFrom(ref input, GetTreasureDungeonActivityDataScRsp._repeated_jFPIPIBOIFC_codec);
				}
			}
		}

		// Token: 0x04002411 RID: 9233
		private static readonly MessageParser<GetTreasureDungeonActivityDataScRsp> _parser = new MessageParser<GetTreasureDungeonActivityDataScRsp>(() => new GetTreasureDungeonActivityDataScRsp());

		// Token: 0x04002412 RID: 9234
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002413 RID: 9235
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04002414 RID: 9236
		private uint retcode_;

		// Token: 0x04002415 RID: 9237
		public const int JFPIPIBOIFCFieldNumber = 5;

		// Token: 0x04002416 RID: 9238
		private static readonly FieldCodec<TreasureDungeonActivityData> _repeated_jFPIPIBOIFC_codec = FieldCodec.ForMessage<TreasureDungeonActivityData>(42U, TreasureDungeonActivityData.Parser);

		// Token: 0x04002417 RID: 9239
		private readonly RepeatedField<TreasureDungeonActivityData> jFPIPIBOIFC_ = new RepeatedField<TreasureDungeonActivityData>();
	}
}
