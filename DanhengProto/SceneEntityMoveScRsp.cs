using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001069 RID: 4201
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SceneEntityMoveScRsp : IMessage<SceneEntityMoveScRsp>, IMessage, IEquatable<SceneEntityMoveScRsp>, IDeepCloneable<SceneEntityMoveScRsp>, IBufferMessage
	{
		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0600BB14 RID: 47892 RVA: 0x001F736B File Offset: 0x001F556B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SceneEntityMoveScRsp> Parser
		{
			get
			{
				return SceneEntityMoveScRsp._parser;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0600BB15 RID: 47893 RVA: 0x001F7372 File Offset: 0x001F5572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SceneEntityMoveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0600BB16 RID: 47894 RVA: 0x001F7384 File Offset: 0x001F5584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneEntityMoveScRsp.Descriptor;
			}
		}

		// Token: 0x0600BB17 RID: 47895 RVA: 0x001F738B File Offset: 0x001F558B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityMoveScRsp()
		{
		}

		// Token: 0x0600BB18 RID: 47896 RVA: 0x001F73A0 File Offset: 0x001F55A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityMoveScRsp(SceneEntityMoveScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.entityMotionList_ = other.entityMotionList_.Clone();
			this.downloadData_ = ((other.downloadData_ != null) ? other.downloadData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BB19 RID: 47897 RVA: 0x001F73FD File Offset: 0x001F55FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneEntityMoveScRsp Clone()
		{
			return new SceneEntityMoveScRsp(this);
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0600BB1A RID: 47898 RVA: 0x001F7405 File Offset: 0x001F5605
		// (set) Token: 0x0600BB1B RID: 47899 RVA: 0x001F740D File Offset: 0x001F560D
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

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0600BB1C RID: 47900 RVA: 0x001F7416 File Offset: 0x001F5616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityMotion> EntityMotionList
		{
			get
			{
				return this.entityMotionList_;
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x0600BB1D RID: 47901 RVA: 0x001F741E File Offset: 0x001F561E
		// (set) Token: 0x0600BB1E RID: 47902 RVA: 0x001F7426 File Offset: 0x001F5626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDownloadData DownloadData
		{
			get
			{
				return this.downloadData_;
			}
			set
			{
				this.downloadData_ = value;
			}
		}

		// Token: 0x0600BB1F RID: 47903 RVA: 0x001F742F File Offset: 0x001F562F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneEntityMoveScRsp);
		}

		// Token: 0x0600BB20 RID: 47904 RVA: 0x001F7440 File Offset: 0x001F5640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneEntityMoveScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.entityMotionList_.Equals(other.entityMotionList_) && object.Equals(this.DownloadData, other.DownloadData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BB21 RID: 47905 RVA: 0x001F74A4 File Offset: 0x001F56A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.entityMotionList_.GetHashCode();
			if (this.downloadData_ != null)
			{
				num ^= this.DownloadData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BB22 RID: 47906 RVA: 0x001F7507 File Offset: 0x001F5707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BB23 RID: 47907 RVA: 0x001F750F File Offset: 0x001F570F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BB24 RID: 47908 RVA: 0x001F7518 File Offset: 0x001F5718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			this.entityMotionList_.WriteTo(ref output, SceneEntityMoveScRsp._repeated_entityMotionList_codec);
			if (this.downloadData_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.DownloadData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BB25 RID: 47909 RVA: 0x001F7584 File Offset: 0x001F5784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.entityMotionList_.CalculateSize(SceneEntityMoveScRsp._repeated_entityMotionList_codec);
			if (this.downloadData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DownloadData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BB26 RID: 47910 RVA: 0x001F75F0 File Offset: 0x001F57F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneEntityMoveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.entityMotionList_.Add(other.entityMotionList_);
			if (other.downloadData_ != null)
			{
				if (this.downloadData_ == null)
				{
					this.DownloadData = new ClientDownloadData();
				}
				this.DownloadData.MergeFrom(other.DownloadData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BB27 RID: 47911 RVA: 0x001F7669 File Offset: 0x001F5869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BB28 RID: 47912 RVA: 0x001F7674 File Offset: 0x001F5874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 90U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.downloadData_ == null)
							{
								this.DownloadData = new ClientDownloadData();
							}
							input.ReadMessage(this.DownloadData);
						}
					}
					else
					{
						this.entityMotionList_.AddEntriesFrom(ref input, SceneEntityMoveScRsp._repeated_entityMotionList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004BE3 RID: 19427
		private static readonly MessageParser<SceneEntityMoveScRsp> _parser = new MessageParser<SceneEntityMoveScRsp>(() => new SceneEntityMoveScRsp());

		// Token: 0x04004BE4 RID: 19428
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BE5 RID: 19429
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04004BE6 RID: 19430
		private uint retcode_;

		// Token: 0x04004BE7 RID: 19431
		public const int EntityMotionListFieldNumber = 11;

		// Token: 0x04004BE8 RID: 19432
		private static readonly FieldCodec<EntityMotion> _repeated_entityMotionList_codec = FieldCodec.ForMessage<EntityMotion>(90U, EntityMotion.Parser);

		// Token: 0x04004BE9 RID: 19433
		private readonly RepeatedField<EntityMotion> entityMotionList_ = new RepeatedField<EntityMotion>();

		// Token: 0x04004BEA RID: 19434
		public const int DownloadDataFieldNumber = 12;

		// Token: 0x04004BEB RID: 19435
		private ClientDownloadData downloadData_;
	}
}
