using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000439 RID: 1081
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterChallengeNextPhaseScRsp : IMessage<EnterChallengeNextPhaseScRsp>, IMessage, IEquatable<EnterChallengeNextPhaseScRsp>, IDeepCloneable<EnterChallengeNextPhaseScRsp>, IBufferMessage
	{
		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x0008405D File Offset: 0x0008225D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterChallengeNextPhaseScRsp> Parser
		{
			get
			{
				return EnterChallengeNextPhaseScRsp._parser;
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x00084064 File Offset: 0x00082264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterChallengeNextPhaseScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06003005 RID: 12293 RVA: 0x00084076 File Offset: 0x00082276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterChallengeNextPhaseScRsp.Descriptor;
			}
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x0008407D File Offset: 0x0008227D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChallengeNextPhaseScRsp()
		{
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x00084088 File Offset: 0x00082288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChallengeNextPhaseScRsp(EnterChallengeNextPhaseScRsp other) : this()
		{
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x000840D4 File Offset: 0x000822D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChallengeNextPhaseScRsp Clone()
		{
			return new EnterChallengeNextPhaseScRsp(this);
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x000840DC File Offset: 0x000822DC
		// (set) Token: 0x0600300A RID: 12298 RVA: 0x000840E4 File Offset: 0x000822E4
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

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x000840ED File Offset: 0x000822ED
		// (set) Token: 0x0600300C RID: 12300 RVA: 0x000840F5 File Offset: 0x000822F5
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

		// Token: 0x0600300D RID: 12301 RVA: 0x000840FE File Offset: 0x000822FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterChallengeNextPhaseScRsp);
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x0008410C File Offset: 0x0008230C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterChallengeNextPhaseScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Scene, other.Scene) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x0008415C File Offset: 0x0008235C
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

		// Token: 0x06003010 RID: 12304 RVA: 0x000841B1 File Offset: 0x000823B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x000841B9 File Offset: 0x000823B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x000841C4 File Offset: 0x000823C4
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
				output.WriteRawTag(122);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x00084220 File Offset: 0x00082420
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

		// Token: 0x06003014 RID: 12308 RVA: 0x00084278 File Offset: 0x00082478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterChallengeNextPhaseScRsp other)
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

		// Token: 0x06003015 RID: 12309 RVA: 0x000842E0 File Offset: 0x000824E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x000842EC File Offset: 0x000824EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 122U)
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

		// Token: 0x04001322 RID: 4898
		private static readonly MessageParser<EnterChallengeNextPhaseScRsp> _parser = new MessageParser<EnterChallengeNextPhaseScRsp>(() => new EnterChallengeNextPhaseScRsp());

		// Token: 0x04001323 RID: 4899
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001324 RID: 4900
		public const int SceneFieldNumber = 15;

		// Token: 0x04001325 RID: 4901
		private SceneInfo scene_;

		// Token: 0x04001326 RID: 4902
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04001327 RID: 4903
		private uint retcode_;
	}
}
