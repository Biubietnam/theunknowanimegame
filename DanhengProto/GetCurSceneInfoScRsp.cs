using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200067D RID: 1661
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCurSceneInfoScRsp : IMessage<GetCurSceneInfoScRsp>, IMessage, IEquatable<GetCurSceneInfoScRsp>, IDeepCloneable<GetCurSceneInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06004A65 RID: 19045 RVA: 0x000CA711 File Offset: 0x000C8911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCurSceneInfoScRsp> Parser
		{
			get
			{
				return GetCurSceneInfoScRsp._parser;
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06004A66 RID: 19046 RVA: 0x000CA718 File Offset: 0x000C8918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCurSceneInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06004A67 RID: 19047 RVA: 0x000CA72A File Offset: 0x000C892A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCurSceneInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x000CA731 File Offset: 0x000C8931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurSceneInfoScRsp()
		{
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x000CA73C File Offset: 0x000C893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurSceneInfoScRsp(GetCurSceneInfoScRsp other) : this()
		{
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x000CA788 File Offset: 0x000C8988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurSceneInfoScRsp Clone()
		{
			return new GetCurSceneInfoScRsp(this);
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06004A6B RID: 19051 RVA: 0x000CA790 File Offset: 0x000C8990
		// (set) Token: 0x06004A6C RID: 19052 RVA: 0x000CA798 File Offset: 0x000C8998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06004A6D RID: 19053 RVA: 0x000CA7A1 File Offset: 0x000C89A1
		// (set) Token: 0x06004A6E RID: 19054 RVA: 0x000CA7A9 File Offset: 0x000C89A9
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

		// Token: 0x06004A6F RID: 19055 RVA: 0x000CA7B2 File Offset: 0x000C89B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCurSceneInfoScRsp);
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x000CA7C0 File Offset: 0x000C89C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCurSceneInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Scene, other.Scene) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x000CA810 File Offset: 0x000C8A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
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

		// Token: 0x06004A72 RID: 19058 RVA: 0x000CA865 File Offset: 0x000C8A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x000CA86D File Offset: 0x000C8A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x000CA878 File Offset: 0x000C8A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x000CA8D4 File Offset: 0x000C8AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
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

		// Token: 0x06004A76 RID: 19062 RVA: 0x000CA92C File Offset: 0x000C8B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCurSceneInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x000CA994 File Offset: 0x000C8B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x000CA9A0 File Offset: 0x000C8BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.scene_ == null)
						{
							this.Scene = new SceneInfo();
						}
						input.ReadMessage(this.Scene);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001D85 RID: 7557
		private static readonly MessageParser<GetCurSceneInfoScRsp> _parser = new MessageParser<GetCurSceneInfoScRsp>(() => new GetCurSceneInfoScRsp());

		// Token: 0x04001D86 RID: 7558
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D87 RID: 7559
		public const int SceneFieldNumber = 6;

		// Token: 0x04001D88 RID: 7560
		private SceneInfo scene_;

		// Token: 0x04001D89 RID: 7561
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04001D8A RID: 7562
		private uint retcode_;
	}
}
