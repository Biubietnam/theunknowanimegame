using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000431 RID: 1073
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterAdventureScRsp : IMessage<EnterAdventureScRsp>, IMessage, IEquatable<EnterAdventureScRsp>, IDeepCloneable<EnterAdventureScRsp>, IBufferMessage
	{
		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x00083569 File Offset: 0x00081769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterAdventureScRsp> Parser
		{
			get
			{
				return EnterAdventureScRsp._parser;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x00083570 File Offset: 0x00081770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterAdventureScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x00083582 File Offset: 0x00081782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAdventureScRsp.Descriptor;
			}
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00083589 File Offset: 0x00081789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAdventureScRsp()
		{
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x00083594 File Offset: 0x00081794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAdventureScRsp(EnterAdventureScRsp other) : this()
		{
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x000835E0 File Offset: 0x000817E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAdventureScRsp Clone()
		{
			return new EnterAdventureScRsp(this);
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x000835E8 File Offset: 0x000817E8
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x000835F0 File Offset: 0x000817F0
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

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x000835F9 File Offset: 0x000817F9
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x00083601 File Offset: 0x00081801
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

		// Token: 0x06002FB7 RID: 12215 RVA: 0x0008360A File Offset: 0x0008180A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAdventureScRsp);
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x00083618 File Offset: 0x00081818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAdventureScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Scene, other.Scene) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x00083668 File Offset: 0x00081868
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

		// Token: 0x06002FBA RID: 12218 RVA: 0x000836BD File Offset: 0x000818BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x000836C5 File Offset: 0x000818C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x000836D0 File Offset: 0x000818D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x0008372C File Offset: 0x0008192C
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

		// Token: 0x06002FBE RID: 12222 RVA: 0x00083784 File Offset: 0x00081984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterAdventureScRsp other)
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

		// Token: 0x06002FBF RID: 12223 RVA: 0x000837EC File Offset: 0x000819EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x000837F8 File Offset: 0x000819F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 82U)
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

		// Token: 0x0400130C RID: 4876
		private static readonly MessageParser<EnterAdventureScRsp> _parser = new MessageParser<EnterAdventureScRsp>(() => new EnterAdventureScRsp());

		// Token: 0x0400130D RID: 4877
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400130E RID: 4878
		public const int SceneFieldNumber = 10;

		// Token: 0x0400130F RID: 4879
		private SceneInfo scene_;

		// Token: 0x04001310 RID: 4880
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04001311 RID: 4881
		private uint retcode_;
	}
}
