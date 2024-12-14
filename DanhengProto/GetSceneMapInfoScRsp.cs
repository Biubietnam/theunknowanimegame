using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007E7 RID: 2023
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSceneMapInfoScRsp : IMessage<GetSceneMapInfoScRsp>, IMessage, IEquatable<GetSceneMapInfoScRsp>, IDeepCloneable<GetSceneMapInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06005A3E RID: 23102 RVA: 0x000F0ABB File Offset: 0x000EECBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSceneMapInfoScRsp> Parser
		{
			get
			{
				return GetSceneMapInfoScRsp._parser;
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x06005A3F RID: 23103 RVA: 0x000F0AC2 File Offset: 0x000EECC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSceneMapInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x06005A40 RID: 23104 RVA: 0x000F0AD4 File Offset: 0x000EECD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSceneMapInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x000F0ADB File Offset: 0x000EECDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSceneMapInfoScRsp()
		{
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x000F0AF0 File Offset: 0x000EECF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSceneMapInfoScRsp(GetSceneMapInfoScRsp other) : this()
		{
			this.sceneMapInfo_ = other.sceneMapInfo_.Clone();
			this.pNFPBICGDPC_ = other.pNFPBICGDPC_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x000F0B3D File Offset: 0x000EED3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSceneMapInfoScRsp Clone()
		{
			return new GetSceneMapInfoScRsp(this);
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x000F0B45 File Offset: 0x000EED45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SceneMapInfo> SceneMapInfo
		{
			get
			{
				return this.sceneMapInfo_;
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x06005A45 RID: 23109 RVA: 0x000F0B4D File Offset: 0x000EED4D
		// (set) Token: 0x06005A46 RID: 23110 RVA: 0x000F0B55 File Offset: 0x000EED55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PNFPBICGDPC
		{
			get
			{
				return this.pNFPBICGDPC_;
			}
			set
			{
				this.pNFPBICGDPC_ = value;
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06005A47 RID: 23111 RVA: 0x000F0B5E File Offset: 0x000EED5E
		// (set) Token: 0x06005A48 RID: 23112 RVA: 0x000F0B66 File Offset: 0x000EED66
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

		// Token: 0x06005A49 RID: 23113 RVA: 0x000F0B6F File Offset: 0x000EED6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSceneMapInfoScRsp);
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x000F0B80 File Offset: 0x000EED80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSceneMapInfoScRsp other)
		{
			return other != null && (other == this || (this.sceneMapInfo_.Equals(other.sceneMapInfo_) && this.PNFPBICGDPC == other.PNFPBICGDPC && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x000F0BE0 File Offset: 0x000EEDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.sceneMapInfo_.GetHashCode();
			if (this.PNFPBICGDPC)
			{
				num ^= this.PNFPBICGDPC.GetHashCode();
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

		// Token: 0x06005A4C RID: 23116 RVA: 0x000F0C46 File Offset: 0x000EEE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x000F0C4E File Offset: 0x000EEE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x000F0C58 File Offset: 0x000EEE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PNFPBICGDPC)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.PNFPBICGDPC);
			}
			this.sceneMapInfo_.WriteTo(ref output, GetSceneMapInfoScRsp._repeated_sceneMapInfo_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x000F0CC4 File Offset: 0x000EEEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sceneMapInfo_.CalculateSize(GetSceneMapInfoScRsp._repeated_sceneMapInfo_codec);
			if (this.PNFPBICGDPC)
			{
				num += 2;
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

		// Token: 0x06005A50 RID: 23120 RVA: 0x000F0D24 File Offset: 0x000EEF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSceneMapInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.sceneMapInfo_.Add(other.sceneMapInfo_);
			if (other.PNFPBICGDPC)
			{
				this.PNFPBICGDPC = other.PNFPBICGDPC;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x000F0D85 File Offset: 0x000EEF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x000F0D90 File Offset: 0x000EEF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 66U)
					{
						if (num != 72U)
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
						this.sceneMapInfo_.AddEntriesFrom(ref input, GetSceneMapInfoScRsp._repeated_sceneMapInfo_codec);
					}
				}
				else
				{
					this.PNFPBICGDPC = input.ReadBool();
				}
			}
		}

		// Token: 0x0400230A RID: 8970
		private static readonly MessageParser<GetSceneMapInfoScRsp> _parser = new MessageParser<GetSceneMapInfoScRsp>(() => new GetSceneMapInfoScRsp());

		// Token: 0x0400230B RID: 8971
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400230C RID: 8972
		public const int SceneMapInfoFieldNumber = 8;

		// Token: 0x0400230D RID: 8973
		private static readonly FieldCodec<SceneMapInfo> _repeated_sceneMapInfo_codec = FieldCodec.ForMessage<SceneMapInfo>(66U, EggLink.DanhengServer.Proto.SceneMapInfo.Parser);

		// Token: 0x0400230E RID: 8974
		private readonly RepeatedField<SceneMapInfo> sceneMapInfo_ = new RepeatedField<SceneMapInfo>();

		// Token: 0x0400230F RID: 8975
		public const int PNFPBICGDPCFieldNumber = 5;

		// Token: 0x04002310 RID: 8976
		private bool pNFPBICGDPC_;

		// Token: 0x04002311 RID: 8977
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04002312 RID: 8978
		private uint retcode_;
	}
}
